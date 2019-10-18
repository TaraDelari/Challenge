using System;

namespace Challenge.Api.DataContracts.Out
{
    public class LoginDto
    {
        public UserDto User { get; set; }
        public string Token { get; set; }
    }
}
