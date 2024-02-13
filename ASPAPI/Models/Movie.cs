namespace ASPAPI.Models
{
    public sealed class Movie
    {
        private int         _id;
        private string      _title;
        private string      _description;
        private string      _type;
        private int         _stars;

        public required int    Id          { get; set; }
        public required string Title       { get; set; }
        public required string Description { get; set; }
        public required string Type        { get; set; }
        public required int    Stars       { get; set; }
    }
}
