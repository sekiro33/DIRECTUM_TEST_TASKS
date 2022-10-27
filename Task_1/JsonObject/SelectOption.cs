using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace FormGenerator.JsonObject
{
    class SelectOption
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonPropertyName("selected")]
        public bool Selected { get; set; }
    }
}
