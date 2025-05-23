// Defines all properties related to Character
namespace StarWarsApp.Models
{
    public class Character
    {
        public string? Name { get; set; }
        public string? Height { get; set; }
        public string? Mass { get; set; }
        public string? Hair_Color { get; set; }
        public string? Skin_Color { get; set; }
        public string? Eye_Color { get; set; }
        public string? Birth_Year { get; set; }
        public string? Gender { get; set; }
        public string? Homeworld { get; set; }
        public List<string> Films { get; set; } = new List<string>();
        public List<string> Species { get; set; } = new List<string>();
        public List<string> Vehicles { get; set; } = new List<string>();
        public List<string> Starships { get; set; } = new List<string>();
        public string? Url { get; set; } 
        public string? HomeworldName { get; set; }
    }
}
