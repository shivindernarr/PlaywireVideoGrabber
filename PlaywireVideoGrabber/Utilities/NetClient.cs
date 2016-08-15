using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PlaywireVideoGrabber.Utilities
{
    public class NetClient
    {
        private readonly HttpClient _client;

        public NetClient(HttpClient client)
        {
            _client = client;            
        }

        public async Task<string> GetStringContentAsync(string url)
        {
            try
            {
                var contentAsBytes = await _client.GetByteArrayAsync(url);
                return Encoding.UTF8.GetString(contentAsBytes);
            }
            catch (Exception)
            {
                return string.Empty;
            }
            
        }        
    }
}