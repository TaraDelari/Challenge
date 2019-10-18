using System.ComponentModel.DataAnnotations;

namespace Challenge.Api.DataContracts.In
{
    public class RegisterRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Must be between 6 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}