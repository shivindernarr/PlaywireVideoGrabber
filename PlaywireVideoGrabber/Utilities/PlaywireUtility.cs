using System.Threading.Tasks;
using PlaywireVideoGrabber.Enums;

namespace PlaywireVideoGrabber.Utilities
{
    public class PlaywireUtility
    {
        private readonly UrlUtility _urlUtility;
        private const string FirstPattern = @"config.playwire.com(\S)+zeus.json";
        private const string SecondPattern = @"publisherId"":(\d)+";

        public PlaywireUtility(UrlUtility urlUtility)
        {
            _urlUtility = urlUtility;            
        }

        private string GetVideoSubUrl(PlaywireVideo type)
        {
            string value = "video-sd.mp4";
            if (type == PlaywireVideo.Standard)
            {
                value = "video-mobile.mp4";
            }

            return value;
        }

        public async Task<string> GetVideoLink(string url, PlaywireVideo type)
        {
            var value = await _urlUtility.GetRegexMatch(url, FirstPattern);
            var publisherIdTask = _urlUtility.GetRegexMatch("http://" + value, SecondPattern);
            var list = value.Split('/');
            var videoId = list[list.Length - 2];                               
            var publisherId = (await publisherIdTask).Split(':')[1];
            return $"https://cdn.video.playwire.com/{publisherId}/videos/{videoId}/{GetVideoSubUrl(type)}";
        }
    }
}