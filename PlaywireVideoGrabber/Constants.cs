using System.Collections.Generic;
using PlaywireVideoGrabber.Models;

namespace PlaywireVideoGrabber
{
    public static class Constants
    {
        public const string DateFormat = "d{0}-MMMM-yyyy";
        public const string YoDesiPattern = @"/player.php\?id=(\d)+";
        public const string YoDesiBaseUrl = "http://www.yo-desi.com";

        public static readonly List<SerialInfo> PredefinedSerials = new List<SerialInfo>
        {
            new SerialInfo
            {
                Name = "Siya Ke Ram",
                Template = "http://www.yodesi.net/siya-ke-ram-{0}-watch-online/",
                LinkBaseUrl = "http://www.yo-desi.com",
                DateFormat = "d{0}-MMMM-yyyy",
                LinkSubUrlRegex = @"/player.php\?id=(\d)+"
            },
            new SerialInfo
            {
                Name = "Yeh Hai Mohabbatein",
                Template = "http://www.yodesi.net/yeh-hai-mohabbatein-{0}-watch-online/",
                LinkBaseUrl = "http://www.yo-desi.com",
                DateFormat = "d{0}-MMMM-yyyy",
                LinkSubUrlRegex = @"/player.php\?id=(\d)+"
            },
            new SerialInfo
            {
                Name = "Saath Nibhana Saathiya",
                Template = "http://www.yodesi.net/saath-nibhaana-saathiya-{0}-watch-online/",
                LinkBaseUrl = "http://www.yo-desi.com",
                DateFormat = "d{0}-MMMM-yyyy",
                LinkSubUrlRegex = @"/player.php\?id=(\d)+"
            },
            new SerialInfo
            {
                Name = "Swaragini",
                Template = "http://www.yodesi.net/swaragini-{0}-watch-online/",
                LinkBaseUrl = "http://www.yo-desi.com",
                DateFormat = "d{0}-MMMM-yyyy",
                LinkSubUrlRegex = @"/player.php\?id=(\d)+"
            },
            new SerialInfo
            {
                Name = "Sasural Simar Ka",
                Template = "http://www.yodesi.net/sasural-simar-ka-{0}-watch-online/",
                LinkBaseUrl = "http://www.yo-desi.com",
                DateFormat = "d{0}-MMMM-yyyy",
                LinkSubUrlRegex = @"/player.php\?id=(\d)+"
            },
            new SerialInfo
            {
                Name = "Thapki Pyar Ki",
                Template = "http://www.yodesi.net/thapki-pyar-ki-{0}-watch-online/",
                LinkBaseUrl = "http://www.yo-desi.com",
                DateFormat = "d{0}-MMMM-yyyy",
                LinkSubUrlRegex = @"/player.php\?id=(\d)+"
            }
        };
    }
}