using Newtonsoft.Json;
using Web.Model;
using Web.Model1;
using static System.Net.Mime.MediaTypeNames;

namespace Web.Clients
{
    public class InstagramClients
    {
        public async Task<Test> GetInformation(string Nick)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://instagram-scraper-api2.p.rapidapi.com/v1/info?username_or_id_or_url={Nick}"),
                Headers =
    {
        { "X-RapidAPI-Key", "75a2a7740dmsh088da52297efc00p13b4b8jsn0916798f5dea" },
        { "X-RapidAPI-Host", "instagram-scraper-api2.p.rapidapi.com" },
    },
            };
            try
            {
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<Test>(body);
                    return result;
                }
            }
            
            catch (Exception ex)
            {
                return null;
            }
        }



        public async Task<FollowersModel> GetFollowersInformation(string nick)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://instagram-scraper-api2.p.rapidapi.com/v1/followers?username_or_id_or_url={nick}"),
                Headers =
    {
        { "X-RapidAPI-Key", "75a2a7740dmsh088da52297efc00p13b4b8jsn0916798f5dea" },
        { "X-RapidAPI-Host", "instagram-scraper-api2.p.rapidapi.com" },
    },
            };
            try
            {
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject<FollowersModel>(body);
                    return result;
                }

            }

            catch (Exception ex)
            {
                return null;
            }
        }




        public async Task<StoriesModel> GetInformationStory(string Nick)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://instagram-scraper-api2.p.rapidapi.com/v1/stories?username_or_id_or_url={Nick}"),
                Headers =
    {
        { "X-RapidAPI-Key", "75a2a7740dmsh088da52297efc00p13b4b8jsn0916798f5dea" },
        { "X-RapidAPI-Host", "instagram-scraper-api2.p.rapidapi.com" },
    },
            };
            try
            {
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<StoriesModel>(body);
                    return result;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
