namespace GOAT.ViewModels
{
    public class ProductVM
    {
        public required string Serial { get; set; }
        public required string Name { get; set; }
        public required int Stock { get; set; }
        public required double Price { get; set; }
        public required string Image { get; set; }
        public string? Description { get; set; }
    }
}
