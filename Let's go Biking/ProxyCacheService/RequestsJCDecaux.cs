using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProxyCacheService
{
    class RequestsJCDecaux
    {
        string apiKey = "50ec153b29afa9f5ba828901b5ebc98b179e5d83";
         HttpClient client = new HttpClient();
        public async Task<Station> GetOneStation(int stationNumber, string contractName)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://api.jcdecaux.com/vls/v3/stations/"+ stationNumber+"?contract=" + contractName + "&apiKey="+apiKey);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);
                Station station = JsonSerializer.Deserialize<Station>(responseBody);

                return station;

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return null;
            }
        }
        public async Task<List<Station>> GetAllStations()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://api.jcdecaux.com/vls/v3/stations?apiKey=" + apiKey);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);
                List<Station> stations = JsonSerializer.Deserialize<List<Station>>(responseBody);

                return stations;

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return null;
            }
        }
    }
}
