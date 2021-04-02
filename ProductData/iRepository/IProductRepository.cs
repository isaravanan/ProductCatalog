using System;
using System.Collections.Generic;
using ProductData.Entity;

namespace ProductData.IRepository
{
    public interface IProductRepository
    {
        ICollection<Product> GetAllProducts();
        Product GetProduct(int ProductId);
        ICollection<ProductAttribute> GetProductAttributes(int ProductId);
    }
}
