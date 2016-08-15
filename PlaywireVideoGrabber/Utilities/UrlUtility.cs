using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PlaywireVideoGrabber.Utilities
{
    public class UrlUtility
    {
        public NetClient NetClient;        

        public UrlUtility(NetClient netClient)
        {
            NetClient = netClient;            
        }

        public async Task<string> GetRegexMatch(string url, string pattern)
        {
            var content = await NetClient.GetStringContentAsync(url);
            var regex = new Regex(pattern);
            var result = regex.Match(content);
            return result.Success ? result.Value : string.Empty;
        }

        public async Task<List<string>> GetRegexMatches(string url, string pattern)
        {
            var urls = new List<string>();
            var content = await NetClient.GetStringContentAsync(url);
            var regex = new Regex(pattern);
            var result = regex.Match(content);
            while (result.Success)
            {
                urls.Add(result.Value);
                result = result.NextMatch();
            }

            return urls;
        }
    }
}