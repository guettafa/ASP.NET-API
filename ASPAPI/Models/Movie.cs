namespace ASPAPI.Models
{
    public sealed class Movie
    {
        public required int    Id          { get; set; }
        public required string Title       { get; set; }
        public required string Description { get; set; }
        public required string Type        { get; set; }
        public required int    Stars       { get; set; }
    }
}
