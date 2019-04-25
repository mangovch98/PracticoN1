using System.ComponentModel.DataAnnotations;

namespace APIpractico.Models
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        [Required]
        [Display(Name = "Sale Date")]
        public int Date { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int ClientId { get; set; }
    }
}