using Kursach.Data;
using Kursach.Models;
using System.Collections.Generic;
using System.Linq;

namespace Kursach.Services
{
    public class TypeService
    {
        private AppDbContext context;
        public TypeService(AppDbContext context)
        {
            this.context = context;
        }
        public Type AddType(string title)
        {
            Type newType = new Type
            {
                Id = 1,
                title = title
            };
            context.Type.Add(newType);
            context.SaveChanges();
            return newType;
        }
        public Type GetType(int id)
        {
            return context.Type
                .Where(s => s.Id == id)
                .FirstOrDefault();
        }
    }
}