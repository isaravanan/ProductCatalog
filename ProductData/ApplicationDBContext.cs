using System;
using Microsoft.EntityFrameworkCore;
using ProductData.Entity;

namespace ProductData
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
    }
}
