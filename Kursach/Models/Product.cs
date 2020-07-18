namespace Kursach.Models
{
    public class Product
    {
        public int Id {get; set; }
        public Type type {get; set; }
        //not a string!
        public string model {get; set; }
        //not a string!
        public string quality {get; set; }
        public int year {get; set; }
        public string name {get; set; }
        public decimal price {get; set; }
    }
}