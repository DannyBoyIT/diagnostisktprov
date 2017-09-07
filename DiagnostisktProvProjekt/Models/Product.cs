using System.ComponentModel.DataAnnotations;

namespace DiagnostisktProvProjekt.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(5,1000)]
        public decimal Price { get; set; }
    }
}
