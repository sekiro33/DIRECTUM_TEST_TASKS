using System.Text.Json.Serialization;


namespace FormGenerator.JsonObject
{
    class RootObject
    {
        [JsonPropertyName("form")]
        public FormObject Form { get; set; }
    }
}
