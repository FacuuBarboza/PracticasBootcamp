using APIGestionProductos.Models;
using APIGestionProductos.DTOs;

namespace APIGestionProductos.Mappers
{
    public static class ProductMapper
    {
        public static ProductDto ToDto(this Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Category = product.Category,
                IsAvailable = product.IsAvailable
            };
        }

        public static Product ToEntity(this CreateProductDto dto)
        {
            return new Product
            {
                Name = dto.Name,
                Price = dto.Price,
                Category = dto.Category,
            };
        }
    }
}
