namespace MovieAggregator.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Stars { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
