using System.ComponentModel.DataAnnotations;

namespace MyLeasings.Models
{
    public class RecoverPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
