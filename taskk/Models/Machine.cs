using System.ComponentModel.DataAnnotations;
namespace taskk.Models
{
    public class Machine
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public double price { get; set; }
        
        public int discount { get; set; }

        public string imgSrc { get; set; }


    }
}
