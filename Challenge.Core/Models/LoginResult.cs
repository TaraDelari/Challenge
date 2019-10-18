using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Core.Models
{
    public class LoginResult
    {
        public User User { get; }
        public string Token { get; }

        internal LoginResult(User user, string token)
        {
            User = user;
            Token = token;
        }
    }
}
