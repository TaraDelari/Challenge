using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Core.Contracts
{
    public interface IKeywordsExtractor
    {
        IEnumerable<string> Extract(string text);
    }
}
