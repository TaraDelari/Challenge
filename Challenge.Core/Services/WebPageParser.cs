using Challenge.Core.Contracts;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.Core.Services
{
    public class WebPageParser : IWebPageParser
    {
        public string Parse(string url)
        {
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(url);

            var paragraphNodes = htmlDoc.DocumentNode.SelectNodes("//body//p");
            List<string> paragraphs = paragraphNodes.Select(x => x.InnerText).Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            string text = string.Join(" ", paragraphs);
            return text;
        }
    }
}