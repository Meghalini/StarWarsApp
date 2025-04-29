using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using StarWarsApp.Models;

namespace StarWarsApp.Services
{
    // SwapiService API Class
    public class SwapiService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://swapi.py4e.com/api/";

        public SwapiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //Get Planet Data
        public async Task<List<Planet>> GetPlanetsAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<ApiResult<Planet>>(BaseUrl + "planets/");
            return result?.Results ?? new List<Planet>();
        }

        //Get Characters Data
        public async Task<List<Character>> GetCharactersAsync()
        {
            var characters = new List<Character>();
            int page = 1;
            bool hasMore = true;

            while (hasMore)
            {
                var result = await _httpClient.GetFromJsonAsync<ApiResult<Character>>(BaseUrl + $"people/?page={page}");

                if (result?.Results != null && result.Results.Count > 0)
                {
                    characters.AddRange(result.Results);
                    page++;
                    hasMore = result.Next != null; // if next page exists, continue
                }
                else
                {
                    hasMore = false;
                }
            }

            return characters;
        }

        //Get StarShips Data
        public async Task<List<Starship>> GetStarshipsAsync()
        {
            var Starship = new List<Starship>();
            int page = 1;
            bool hasMore = true;

            while (hasMore)
            {
                var result = await _httpClient.GetFromJsonAsync<ApiResult<Starship>>(BaseUrl + $"starships/?page={page}");

                if (result?.Results != null && result.Results.Count > 0)
                {
                    Starship.AddRange(result.Results);
                    page++;
                    hasMore = result.Next != null; // if next page exists, continue
                }
                else
                {
                    hasMore = false;
                }
            }

            return Starship;
        }

        //Get Films Data
        public async Task<List<Film>> GetFilmsAsync(int page = 1)
        {
            var result = await _httpClient.GetFromJsonAsync<ApiResult<Film>>(BaseUrl + $"films/?page={page}");
            return result?.Results ?? new List<Film>();
        }

        //Get List of URLs Data
        public async Task<List<string>> GetNamesAsync(List<string> urls)
        {
            var names = new List<string>();

            foreach (var url in urls)
            {
                try
                {
                    var json = await _httpClient.GetFromJsonAsync<JsonElement>(url); 
                    if (json.TryGetProperty("name", out var name))
                    {
                        names.Add(name.GetString());
                    }
                    else if (json.TryGetProperty("title", out var title))
                    {
                        names.Add(title.GetString());
                    }
                }
                catch
                {
                    names.Add("Unknown");
                }
            }

            return names;
        }

        //Get URL Data
        public async Task<string> GetNameAsync(string url)
        {
            var Name = "";

            var json = await _httpClient.GetFromJsonAsync<JsonElement>(url); 
            if (json.TryGetProperty("name", out var name))
            {
                Name = name.GetString();
            }
            else if (json.TryGetProperty("title", out var title))
            {
                Name = title.GetString();
            }

            return Name;
        }

        public async Task<string> GetIdAsync(string url)
        {
            string id = "";

            var json = await _httpClient.GetFromJsonAsync<JsonElement>(url);

            if (json.TryGetProperty("episode_id", out var episodeId))
            {
                id = episodeId.GetInt32().ToString();
            }
            else if (json.TryGetProperty("id", out var genericId))
            {
                id = genericId.GetInt32().ToString();
            }

            return id;
        }


        public async Task<Character> GetCharacterDetailsAsync(string url)
        {
            var character = await _httpClient.GetFromJsonAsync<Character>(url);
            return character ?? new Character();
        }

        public async Task<Starship> GetStarshipDetailsAsync(string url)
        {
            return await _httpClient.GetFromJsonAsync<Starship>(url);
        }

    }

    public class ApiResult<T>
    {
        public int Count { get; set; }
        public string? Next { get; set; }
        public string? Previous { get; set; }
        public List<T> Results { get; set; }
    }

    // StarshipListResponse model
    public class StarshipListResponse
    {
        public List<Starship> Results { get; set; }
    }
}
