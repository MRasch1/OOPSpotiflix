namespace OOPSpotiflix
{
    //Sealed means that inheritance can´t derive from "Movie" in this context.
    internal sealed class Movie : Media
    {
        public string? Title { get; set; }
        public DateTime Length { get; set; }
        public string? Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? WWW { get; set; }

        public string GetLength()
        {
            return Length.ToString("hh:mm");
        }
        public string GetReleaseDate()
        {
            return ReleaseDate.ToString("D");
        }
    }
}
