namespace EGzone1.DTOs
{
    public class CreateProductDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        public int SubCategoryId { get; set; }

        public string? ImageUrl { get; set; }

    }
}