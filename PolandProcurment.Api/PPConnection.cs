using PP.Connection.JsonDataClasses;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace PP.Connection
{
    public class PPConnection
    {
        private static readonly string apiBasiUri = "https://tenders.guru/api/pl/tenders";

        public PPConnection()
        {

        }

        public string Get(string url)
        {
            var query = apiBasiUri + url;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(query);
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";

            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            var msg = reader.ReadToEnd();
            reader.Close();
            return msg;
        }

        public T DeserializeJson<T>(string jsonMsg)
        {
            return JsonSerializer.Deserialize<T>(jsonMsg);
        }
    }
}
