using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FlowersWebsite.Models
{
    public class Flowers
    {
        public string Id { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Flowers>(this);
        public int[] Ratings { get; set; }

    }
}
