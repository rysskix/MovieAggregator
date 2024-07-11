namespace MovieAggregator.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
