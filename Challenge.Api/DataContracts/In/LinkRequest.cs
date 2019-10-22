using Challenge.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace Challenge.Api.DataContracts.In
{
    public class LinkRequest
    {
        [Required]
        public string Link { get; set; }
        [Required]
        [MustHaveOneElement(ErrorMessage = "At least one tag is required")]
        public string[] Tags { get; set; }
    }
}