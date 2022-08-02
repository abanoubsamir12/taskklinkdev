
using System.ComponentModel.DataAnnotations;
namespace taskk.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
                    
    }
}
