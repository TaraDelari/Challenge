using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Core.Contracts
{
    public interface IWebPageParser
    {
        string Parse(string url);
    }
}
