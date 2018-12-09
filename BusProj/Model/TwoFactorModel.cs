using System.ComponentModel.DataAnnotations;

namespace PluralsightDemo.Models
{
    public class TwoFactorModel
    {
        [Required]
        public string Token { get; set; }
    }
}