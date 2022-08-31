using System.ComponentModel.DataAnnotations;

namespace Mango.Services.Product.API.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1, 1000)]
        public string Price { get; set; }

        public string Description { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }

        public string ImageUrl { get; set; }
    }
}
