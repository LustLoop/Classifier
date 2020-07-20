using Kursach.Data;
using Kursach.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Kursach.Services
{
    public class ProductService
    {
        private AppDbContext context;
        public ProductService(AppDbContext context)
        {
            this.context = context;
        }
        public Product AddProduct(int typeId, string model, int purposeId, int qualityId, int year, string title, double price)
        {
            Product newProduct = new Product
            {
                model = model,
                year = year,
                title = title,
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
    }
}