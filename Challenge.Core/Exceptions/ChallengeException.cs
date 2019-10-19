using System;

namespace Challenge.Core.Exceptions
{
    public class ChallengeException : Exception
    {
        public ChallengeException(string message) : base(message) {}
        public ChallengeException(string message, Exception inner) : base(message, inner) {} 
    }
}
