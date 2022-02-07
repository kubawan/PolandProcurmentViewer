using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PP.Data.Models
{
    public class Tenders
    {
        [JsonPropertyName("page_count")]
        public int PageCount { get; set; }

        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }

        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("data")]
        public List<Tender>? TendersList { get; set; }
    }
}
