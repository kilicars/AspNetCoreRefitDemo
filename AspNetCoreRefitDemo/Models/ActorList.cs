using System.Text.Json.Serialization;

namespace AspNetCoreRefitDemo.Models
{
    public class ActorList
    {
        [JsonPropertyName("results")]
        public List<Actor> Actors { get; set; }
    }
}
