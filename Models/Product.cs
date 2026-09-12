namespace Lesson_4.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }
        public bool IsHot { get; set; }
    }
}
