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

        public string Get(string requestDetails, RequestType requestType)
        {
            var query = GetQuery(requestDetails, requestType);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(query);
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";

            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            var msg = reader.ReadToEnd();
            reader.Close();
            return msg;
        }

        private string GetQuery(string requestDetails, RequestType requestType)
        {
            switch (requestType)
            {
                case RequestType.ListTenders:
                    return $"{apiBasiUri}";
                case RequestType.TenderDetails:
                    return $"{apiBasiUri}/{requestDetails}";
                default:
                    return "";
            }
        }

        public T DeserializeJson<T>(string jsonMsg)
        {
            return JsonSerializer.Deserialize<T>(jsonMsg);
        }
    }
}
