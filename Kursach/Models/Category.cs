using System;
using System.Collections;
using System.Collections.Generic;

namespace Kursach.Models
{
    public class Category
    {
        public int Id {get; set; }
        public string title {get; set; }
        public List<CategoryOption> CategoryOptions {get; set; }
        public List<ProductCategory> ProductCategories {get; set; }
    }
}