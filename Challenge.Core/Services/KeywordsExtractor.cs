using Challenge.Core.Contracts;
using Challenge.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge.Core.Services
{
    public class KeywordsExtractor : IKeywordsExtractor
    {
        readonly IUnitOfWork uow;

        public KeywordsExtractor(IUnitOfWork unitOfWork)
        {
            this.uow = unitOfWork;
        }

        public IEnumerable<string> Extract(string text)
        {
            IEnumerable<string> stopwords = uow.StopwordRepository.Get().Select(x => x.Word);
            string[] words = text.Split(new char[] { ' ', '.', ',', '?', '!', ';', ':', '\'' });
            Dictionary<string, long> counts = new Dictionary<string, long>();
            foreach (string word in words)
            {
                if (word.Length > 3)
                {
                    string wordLower = word.ToLower();
                    if (!stopwords.Contains(wordLower))
                    {
                        long currentCount;
                        counts.TryGetValue(word, out currentCount);
                        counts[word] = currentCount + 1; // Will be 0 if doesn't exist
                    }
                }
            }
            IEnumerable<string> keywords = counts.Where(x => x.Value > 2).OrderBy(x => x.Value).Take(10).Select(x => x.Key);

            return keywords;

        }
    }
}
