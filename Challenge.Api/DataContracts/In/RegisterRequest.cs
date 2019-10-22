using System.ComponentModel.DataAnnotations;

namespace Challenge.Api.DataContracts.In
{
    public class RegisterRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Display name must be shorter than 255 characters")]
        public string DisplayName { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}