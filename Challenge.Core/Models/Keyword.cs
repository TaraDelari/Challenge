namespace Challenge.Core.Models
{
    public class Keyword
    {
        public string Word { get; private set; }
        public string WebPageUrl { get; private set; }
        public WebPage WebPage { get; internal set; }

        private Keyword() { }

        public Keyword(string word)
        {
            Word = word;
        }
    }
}