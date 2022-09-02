namespace BlazorWasmPOC.Models
{
    public class Movie
    {
        public string id { get; set; }

        public string l { get; set; }

        public string Title { get { return l; } }

        public string q { get; set; }

        public string Category { get { return q; } }

        public Poster i { get; set; }

        public Poster Poster { get { return i; } }
    }

    public class Poster
    {
        public string imageUrl { get; set; }
    }
}
