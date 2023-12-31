using System.Text.Json.Serialization;

namespace AspNetCoreRefitDemo.Models
{
    public class Rating
    {
        [JsonPropertyName("value")]
        public decimal Value { get; set; }
    }
}
