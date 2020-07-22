using Kursach.Data;
using Kursach.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Kursach.Services
{
    public class CategoryService
    {
        private AppDbContext context;
        public CategoryService(AppDbContext context)
        {
            this.context = context;
        }

        public Category Add()
        {
            Category newCategory = new Category{Id = 1, title = "title"};
            context.Category.Add(newCategory);
            context.SaveChanges();
            return newCategory;
        }

        public Category GetById(int id)
        {
            return context.Category
                .Where(s => s.Id == id)
                .FirstOrDefault();
        }

        public List<Category> GetAll()
        {
            return context.Category.ToList();
        }
    }
}