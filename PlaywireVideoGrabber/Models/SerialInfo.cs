using System.Collections.Generic;

namespace PlaywireVideoGrabber.Models
{
    public class SerialInfo
    {
        public string Name { get; set; } 
        public string Template { get; set; } 
        public List<string> VideoLinks { get; set; }
        public int NumberOfLinks { get; set; } = 2;
        public bool Active { get; set; } = true;
        public string DateFormat { get; set; } = Constants.DateFormat;
        public string LinkBaseUrl { get; set; }
        public string LinkSubUrlRegex { get; set; }
        public string CustomHeaders { get; set; }
    }
}