using System.ComponentModel.DataAnnotations;

namespace Challenge.Api.DataContracts.In
{
    public class UserRequest
    {
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
    }
}