using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Core.Models
{
    public class Stopword
    {
        public string Word { get; private set; }

        private Stopword() { }

        public Stopword(string word)
        {
            Word = word;
        }
    }
}
