using System.ComponentModel.DataAnnotations;

namespace MVCpractico.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        [Display(Name = "Client Name")]
        public string Name { get; set; }
        public string Mail { get; set; }
    }
}