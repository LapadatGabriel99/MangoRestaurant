using Mango.Services.Product.API.Models;
using System.ComponentModel.DataAnnotations;

namespace Mango.Services.Product.API.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public List<CategoryDto> CategoriesDto { get; set; }

        public string ImageUrl { get; set; }
    }
}
