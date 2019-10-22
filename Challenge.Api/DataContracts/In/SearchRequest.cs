using Challenge.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace Challenge.Api.DataContracts.In
{
    public class SearchRequest
    {
        [Required]
        [MustHaveOneElement(ErrorMessage = "At least one tag is required")]
        public string[] Tags { get; set; }
    }
}