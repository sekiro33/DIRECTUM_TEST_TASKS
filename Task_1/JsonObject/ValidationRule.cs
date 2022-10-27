using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace FormGenerator.JsonObject
{
    class ValidationRule
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
