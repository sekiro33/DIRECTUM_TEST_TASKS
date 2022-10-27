using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace FormGenerator.JsonObject
{
    class FormObject
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("postmessage")]
        public string PostMessage { get; set; }

        [JsonPropertyName("items")]
        public Item[] Items { get; set; }
    }
}
