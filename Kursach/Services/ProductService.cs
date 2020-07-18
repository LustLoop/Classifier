using Kursach.Data;
using Kursach.Models;
using System.Collections.Generic;
using System.Linq;

namespace Kursach.Services
{
    public class ProductService
    {
        Product product1 = new Product
        {
            productId = 1,
            type = "instrument",
            name = "test",
            price = 10
        };
        private AppDbContext context;
        public ProductService(AppDbContext context)
        {
            this.context = context;
        }
        public Product AddProduct()
        {
            context.Product.Add(product1);
            context.SaveChanges();
            return product1;
        }

        public List<Product> GetAll()
        {
            return context.Product.ToList();
        }
    }
}