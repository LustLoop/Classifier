namespace Kursach.Models
{
    public class Product
    {
        public int productId {get; set; }
        //not a string!
        public string type {get; set; }
        public string name {get; set; }
        public decimal price {get; set; }
    }
}