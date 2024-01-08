using System.ComponentModel.DataAnnotations;

namespace ProductsCrud.model
{
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }
        // Relación uno a muchos: una categoría puede tener muchos productos
        public ICollection<Product>? Products { get; set; }
    }
}