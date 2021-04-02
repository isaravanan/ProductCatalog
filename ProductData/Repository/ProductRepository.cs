using System;
using System.Collections.Generic;
using System.Linq;
using ProductData.Entity;
using ProductData.IRepository;

namespace ProductData.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly ApplicationDBContext _db;
        public ProductRepository(ApplicationDBContext db)
        {
            _db = db;
        }

        public ICollection<Product> GetAllProducts()
        {
            return _db.Products.OrderBy(a => a.ProductName).ToList();
        }

        public Product GetProduct(int ProductId)
        {
            return _db.Products.FirstOrDefault(a => a.ProductId == ProductId); 
        }

        public ICollection<ProductAttribute> GetProductAttributes(int ProductId)
        {
            return _db.ProductAttributes.OrderBy(a => a.ProductId == ProductId).ToList();
        }
    }
}
