using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace FormGenerator.JsonObject
{
    class RadioOption
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }
        [JsonPropertyName("label")]
        public string Label { get; set; }
        [JsonPropertyName("checked")]
        public bool Checked { get; set; }
    }
}
