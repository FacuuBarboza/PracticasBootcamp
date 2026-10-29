using APIGestionProductos.Models;

namespace APIGestionProductos.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);
        List<Product> GetAll();
        Product GetById(int id);
        List<Product> SearchByCategory(string category);
    }
}
