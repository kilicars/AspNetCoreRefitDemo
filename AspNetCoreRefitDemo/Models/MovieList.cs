using System.Text.Json.Serialization;

namespace AspNetCoreRefitDemo.Models
{
    public class MovieList
    {
        [JsonPropertyName("cast")]
        public List<Movie> Movies { get; set; }
    }
}
