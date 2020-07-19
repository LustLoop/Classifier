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
        public Product AddProduct(int typeId, string model, int purposeId, int qualityId, int year, string name, double price)
        {
            Product newProduct = new Product
            {
                type = GetType(typeId),
                model = model,
                purpose = GetPurpose(purposeId),
                quality = GetQuality(qualityId),
                year = year,
                name = name,
                price = price
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
        public Purpose GetPurpose(int id)
        {
            return context.Purpose
                .Where(s => s.Id == id)
                .FirstOrDefault();
        }
        public Quality GetQuality(int id)
        {
            return context.Quality
                .Where(s => s.Id == id)
                .FirstOrDefault();
        }
    }
}