using System.ComponentModel.DataAnnotations;

namespace PluralsightDemo.Models
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}