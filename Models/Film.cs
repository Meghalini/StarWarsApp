// Defines all properties related to Film
namespace StarWarsApp.Models
{
    public class Film
    {
        public int Episode_Id { get; set; }
        public string? Title { get; set; }
        public string? Director { get; set; }
        public string? Producer { get; set; }
        public DateTime Release_Date { get; set; }
        public string? Opening_Crawl { get; set; } 
        public List<string>? Characters { get; set; }
        public List<string>? Planets { get; set; }
        public List<string>? Starships { get; set; }
        public List<string>? Vehicles { get; set; }
        public List<string>? Species { get; set; }
    }
}
