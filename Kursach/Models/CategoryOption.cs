namespace Kursach.Models
{
    public class CategoryOption
    {
        public int Id { get; set; }
        public int CategoryId {get; set; }
        public Category Category {get; set; }
        public string value {get; set; }
    }
}