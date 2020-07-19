namespace Kursach.Models
{
    public class Product
    {
        public int Id {get; set; }
        public Type type {get; set; }
        public string model {get; set; }
        public Purpose purpose {get; set; }
        public Quality quality {get; set; }
        public int year {get; set; }
        public string name {get; set; }
        public double price {get; set; }

        // public Product(Type type, string model, string quality, int year, string name, double price)
        // {
        //     this.type = type;
        //     this.model = model;
        //     this.quality = quality;
        //     this.year = year;
        //     this.name = name;
        //     this.price = price;
        // }
    }
}