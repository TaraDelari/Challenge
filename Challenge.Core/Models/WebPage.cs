using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Core.Models
{
    public class WebPage
    {
        public string Url { get; private set; }
        public ICollection<Keyword> Keywords { get; private set; }

        private WebPage() { }

        public WebPage(string url)
        {
            Url = url;
        }
    }
}
