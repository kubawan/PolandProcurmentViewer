using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace PP.Connection
{
    public class PPConnection
    {
        private static readonly string apiBasiUri = "https://tenders.guru/api/pl/tenders";

        private HttpClient client { get; set; }

        public PPConnection()
        {
            CreateHttpClient();
        }

        private void CreateHttpClient()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(apiBasiUri);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<T> Get<T>(string url)
        {
            var result = await client.GetAsync(url);
            result.EnsureSuccessStatusCode();
            string resultContentString = await result.Content.ReadAsStringAsync();
            T data = JsonSerializer.Deserialize<T>(resultContentString);
            return data;
        }
    }
}
