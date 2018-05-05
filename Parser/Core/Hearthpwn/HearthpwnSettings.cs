

namespace Parser.Core.Hearthpwn
{
    class HearthpwnSettings : IParserSettings
    {
        public string BaseUrl { get; set; } = "https://www.hearthpwn.com/";
        public string Prefix { get; set; } = "page";
        public int Startpoint { get ; set ; }
        public int Endpoint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
