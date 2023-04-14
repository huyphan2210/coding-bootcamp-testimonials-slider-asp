using System.Text.Json;
using System.Text.Json.Serialization;

namespace CodingBootcampTestimonialsSlider.Models
{
    public class Testimonials
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Testimonials>(this);
    }
}
