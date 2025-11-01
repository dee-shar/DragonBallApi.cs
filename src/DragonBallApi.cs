using System.Net.Http;

namespace TheDragonBallApi
{
    public class DragonBallApi
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://dragonball-api.com/api";
        public DragonBallApi()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36");
        }

        public async Task<string> GetCharacters()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/characters");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetCharacterById(int characterId)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/characters/{characterId}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetPlanets()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/planets");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetPlanetById(int planetId)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/planets/{planetId}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
