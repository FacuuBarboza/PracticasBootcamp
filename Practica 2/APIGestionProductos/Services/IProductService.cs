using APIGestionProductos.DTOs;
using APIGestionProductos.Models;

namespace APIGestionProductos.Services
{
    public interface IProductService
    {
        List<ProductDto> GetAll();
        ProductDto GetById(int id);
        ProductDto AddProduct(CreateProductDto dto);
        bool UpdateProduct(int id, CreateProductDto dto);
        bool DeleteProduct(int id);
    }
}
