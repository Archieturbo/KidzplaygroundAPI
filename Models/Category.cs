using System.Text.Json.Serialization;

namespace KidzplaygroundAPI.Models
{
    public class Category
    {
        [JsonPropertyName("id")]
        public int CategoryId { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

       
    }
}
