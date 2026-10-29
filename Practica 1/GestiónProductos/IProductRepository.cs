using System;
using System.Collections.Generic;
using System.Text;

namespace GestiónProductos
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        List<Product> GetAll();
        Product GetById(int id);
        List<Product> SearchByCategory(string category);
    }
}
