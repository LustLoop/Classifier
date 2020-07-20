using System;
using System.Collections.Generic;

namespace Kursach.Models
{
    public class Product
    {
        public int Id {get; set; }
        // public Type type {get; set; }
        public string model {get; set; }
        // public Purpose purpose {get; set; }
        // public Quality quality {get; set; }
        public int year {get; set; }
        public string title {get; set; }
        public double price {get; set; }
        public List<ProductCategory> ProductCategories {get; set; }
    }
}