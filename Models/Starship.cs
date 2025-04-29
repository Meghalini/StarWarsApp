// Defines all properties related to Starship
namespace StarWarsApp.Models
{
    public class Starship
    {
        public string? Name { get; set; }
        public string? Model { get; set; }
        public string? Manufacturer { get; set; }
        public string? cost_in_credits { get; set; }
        public string? Length { get; set; }
        public string? max_atmosphering_speed { get; set; }
        public string? Crew { get; set; }
        public string? Passengers { get; set; }
        public string? cargo_capacity { get; set; }
        public string? Consumables { get; set; }
        public string? hyperdrive_rating { get; set; }
        public string? MGLT { get; set; }
        public string? starship_class { get; set; }
        public List<string> Pilots { get; set; } = new();
        public List<string> Films { get; set; } = new();
        public string? Url { get; set; }
    }
}
