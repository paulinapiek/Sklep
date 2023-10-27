using System.ComponentModel.DataAnnotations;

namespace filmy.Models
{
    public class ProductM
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; } = default!;
        public string? ProductDescription { get; set; }
        public decimal  ProductPrice { get; set; }

    }
}
