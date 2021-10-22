using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PP.Connection.JsonDataClasses
{
    public class Tender
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("deadline_date")]
        public string DeadlineDate { get; set; }

        [JsonPropertyName("deadline_length_days")]
        public string DeadlineLengthDays { get; set; }

        [JsonPropertyName("deadline_length_hours")]
        public string DeadlineLengthHours { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("sid")]
        public string Sid { get; set; }

        [JsonPropertyName("awarded_value")]
        public string AwardedValue { get; set; }

        [JsonPropertyName("awarded_currency")]
        public string AwardedCurrency { get; set; }

        [JsonPropertyName("awarded_value_eur")]
        public string AwardedValueEur { get; set; }

        [JsonPropertyName("purchaser")]
        public Purchaser Purchaser { get; set; }

        [JsonPropertyName("type")]
        public TenderType Type { get; set; }

        [JsonPropertyName("awarded")]
        public List<Awarded> Awarded { get; set; }

        [JsonPropertyName("indicators")]
        public List<string> Indicators { get; set; }
    }
}
