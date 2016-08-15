using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using PlaywireVideoGrabber.Enums;
using PlaywireVideoGrabber.Models;

namespace PlaywireVideoGrabber.Utilities
{
    public class LinkCrawler
    {        
        private readonly PlaywireUtility _utility;
        private readonly UrlUtility _urlUtility;
        private readonly List<SerialInfo> _serialInfos;

        public LinkCrawler(PlaywireUtility utility, UrlUtility urlUtility, List<SerialInfo> serialInfos)
        {
            _utility = utility;
            _serialInfos = serialInfos;
            _urlUtility = urlUtility;
        }

        private HttpClient GetHttpClientWithHeaders(string headers)
        {
            var httpClient = new HttpClient();
            if (!string.IsNullOrEmpty(headers) && headers.Contains("="))
            {
                var headerList = headers.Split(';');
                foreach (var headerPair in headerList.Select(header => header.Split('=')))
                {
                    httpClient.DefaultRequestHeaders.Add(headerPair[0], headerPair[1]);
                }
            }

            return httpClient;
        }

        private List<string> RetrieveVideos(string url, SerialInfo serial, PlaywireVideo videoType, CancellationToken token, int count = 2)
        {
            var list = new List<KeyValuePair<int, string>>();  
            var tasks = new List<Task>();
            _urlUtility.NetClient = new NetClient(GetHttpClientWithHeaders(serial.CustomHeaders));
            var urls = _urlUtility.GetRegexMatches(url, serial.LinkSubUrlRegex).Result;
            if (urls.Count >= count)
            {
                for (int i = 0; i < count; i++)
                {
                    var i1 = i;
                    tasks.Add(Task.Factory.StartNew(() =>
                    {
                        list.Add(new KeyValuePair<int, string>(i1, _utility.GetVideoLink(serial.LinkBaseUrl + urls[i1], videoType).Result));
                    }, token));
                }
            }

            Task.WaitAll(tasks.ToArray(), token);  

            return list.OrderBy(x => x.Key).Select(x => x.Value).ToList();
        }

        private string DaySuffix(int day)
        {
            if (day >= 11 && day <= 13)
            {
                return "th";
            }
            switch (day % 10)
            {
                case 1: return "st";
                case 2: return "nd";
                case 3: return "rd";
                default: return "th";
            }
        }

        private string GetDateString(DateTime date)
        {
            return string.Format(date.ToString(Constants.DateFormat), DaySuffix(date.Day));            
        }

        private string GetFinalLinkUrl(SerialInfo serial, DateTime date)
        {
            var urls = serial.Template.Split(';');
            var finalUrl = string.Format(urls[0], GetDateString(date));
            int count = 1;
            while (count < urls.Length)
            {
                finalUrl = _urlUtility.GetRegexMatch(finalUrl, urls[count++]).Result;
            }

            return finalUrl;
        }  

        public List<SerialInfo> GetLinks(DateTime date, BackgroundWorker bwWorker, PlaywireVideo videoType, CancellationToken cancelToken)
        {                        
            int count = 1;
            var tasks = new List<Task>();
            try
            {
                var serials = _serialInfos.Where(x => x.Active).ToList();
                foreach (var serial in serials)
                {
                    if (bwWorker.CancellationPending)
                    {
                        return _serialInfos;
                    }                    
                    tasks.Add(Task.Factory.StartNew(() =>
                    {
                        var url = GetFinalLinkUrl(serial, date);
                        bwWorker.ReportProgress(count * 50 / serials.Count);
                        serial.VideoLinks = RetrieveVideos(url, serial, videoType, cancelToken, serial.NumberOfLinks);
                        bwWorker.ReportProgress(count++ * 100 / serials.Count);
                    }, cancelToken));
                }

                Task.WaitAll(tasks.ToArray(), cancelToken);
            }
            catch (OperationCanceledException)
            {
                
            }            

            return _serialInfos;
        }
    }
}