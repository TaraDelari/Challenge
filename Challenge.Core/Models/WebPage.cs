using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Core.Models
{
    public class WebPage
    {
        public string Url { get; private set; }
        public ICollection<Keyword> Keywords { get; private set; }

        private WebPage() {
            Keywords = new List<Keyword>();
        }

        public WebPage(string url)
        {
            Url = url;
            Keywords = new List<Keyword>();
        }

        public void AddKeywords(IEnumerable<string> words)
        {
            foreach (string word in words)
                Keywords.Add(new Keyword(word));
        }
    }
}
