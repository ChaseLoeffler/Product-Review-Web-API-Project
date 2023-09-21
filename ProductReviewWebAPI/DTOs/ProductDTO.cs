namespace ProductReviewWebAPI.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public virtual ICollection<ReviewDTO> Reviews { get; set; }
        public double AverageRating { get; set; }
    }
}
