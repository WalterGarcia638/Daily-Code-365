

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsCrud.model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        [StringLength(500)]
        public string? Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        // Clave externa para ProductCategory
        public int ProductCategoryId { get; set; }
        [ForeignKey("ProductCategoryId")]
        public ProductCategory? Category { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsAvailable { get; set; }
    }
}