using System.Net.Http;
using System.Threading.Tasks;

namespace Store.Logic
{
    public class ApiHandler
    {
        private string apiUrl = "https://hex.cse.kau.se/~jonavest/csharp-api/";

        public async Task<string> GetApiResponseAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync(apiUrl);
                return response;
            }
        }
    }
}