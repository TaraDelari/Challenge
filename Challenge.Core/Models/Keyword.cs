namespace Challenge.Core.Models
{
    public class Keyword
    {
        public string Content { get; private set; }
        public string Url { get; private set; }
        public Link Link { get; internal set; }

        private Keyword() { }
    }
}