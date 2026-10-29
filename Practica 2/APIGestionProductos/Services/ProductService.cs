using APIGestionProductos.Repositories;
using APIGestionProductos.Mappers;
using APIGestionProductos.DTOs;

namespace APIGestionProductos.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<ProductDto> GetAll()
        {
            var products = _productRepository.GetAll();
            return products.Select(p => p.ToDto()).ToList();
        }

        public ProductDto GetById(int id)
        {
            var product = _productRepository.GetById(id);
            if (product == null) return null;

            return product.ToDto();
        }

        public ProductDto AddProduct(CreateProductDto dto)
        {
            var product = dto.ToEntity();
            _productRepository.AddProduct(product);
            return product.ToDto();
        }

        public bool UpdateProduct(int id, CreateProductDto dto)
        {
            var existingProduct = _productRepository.GetById(id);
            if (existingProduct == null) return false;

            existingProduct.Name = dto.Name;
            existingProduct.Price = dto.Price;
            existingProduct.Category = dto.Category;
            existingProduct.IsAvailable = dto.IsAvailable;

            _productRepository.UpdateProduct(existingProduct);

            return true;
        }

        public bool DeleteProduct(int id)
        {
            var existingProduct = _productRepository.GetById(id);
            if (existingProduct == null) return false;

            _productRepository.DeleteProduct(id);

            return true;
        }

    }
}
