using System.ComponentModel.DataAnnotations;

namespace taskk.Models
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Pwd { get; set; }

    }
}
