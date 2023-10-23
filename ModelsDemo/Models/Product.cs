namespace ModelsDemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; } //  use ? to allow null.
        public int Price { get; set; }
    }
}
