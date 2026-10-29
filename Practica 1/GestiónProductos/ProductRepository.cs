using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GestiónProductos
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Teclado mecánico", Price = 4500m, Category = "Periféricos", IsAvailable = true },
                new Product { Id = 2, Name = "Mouse inalámbrico", Price = 2500m, Category = "Periféricos", IsAvailable = true },
                new Product { Id = 3, Name = "Monitor 24 pulgadas", Price = 15000m, Category = "Monitores", IsAvailable = true },
                new Product { Id = 4, Name = "NVIDA RTX 3080", Price = 120000m, Category = "Tarjetas gráficas", IsAvailable = false },
                new Product { Id = 5, Name = "Procesador Intel i7", Price = 80000m, Category = "Procesadores", IsAvailable = true },
                new Product { Id = 6, Name = "Iphone 18 pro max", Price = 250000m, Category = "Celulares", IsAvailable = false }
            };
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public List<Product> GetAll()
        {
            return _products.ToList();
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> SearchByCategory(string category)
        {
            return _products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    };
}
