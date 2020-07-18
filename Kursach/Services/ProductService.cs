using Kursach.Data;
using Kursach.Models;
using System.Collections.Generic;
using System.Linq;

namespace Kursach.Services
{
    public class ProductService
    {
        private AppDbContext context;
        public ProductService(AppDbContext context)
        {
            this.context = context;
        }
        public Product AddProduct()
        {
            Product newProduct = new Product{
                Id = 1,
                type = GetType(1),
                model = "test",
                quality = "test",
                year = 2000,
                name = "defaultName",
                price = 10
            };
            context.Product.Add(newProduct);
            context.SaveChanges();
            return newProduct;
        }

        public List<Product> GetAll()
        {
            return context.Product.ToList();
        }

        public Product GetById(int id)
        {
            return context.Product
                .Where(s => s.Id == id)
                .FirstOrDefault();
        }
        public Type GetType(int id)
        {
            return context.Type
                .Where(s => s.Id == id)
                .FirstOrDefault();
        }
    }
}