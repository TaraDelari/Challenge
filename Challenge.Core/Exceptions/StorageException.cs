using System;

namespace Challenge.Core.Exceptions
{
    public class StorageException : ChallengeException
    {
        public StorageException(string message) : base(message) { }
        public StorageException(string message, Exception inner) : base(message, inner) { }
    }
}
