﻿using System.ComponentModel.DataAnnotations;

namespace Challenge.Api.DataContracts.In
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}