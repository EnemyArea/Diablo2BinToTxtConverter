using System.Text.Json.Serialization;

namespace Diablo2BinToTxtConverter
{
    internal sealed record KeyFileStructure
    {
        [JsonPropertyName("id")] public required int Id { get; set; }
        [JsonPropertyName("Key")] public required string Key { get; set; }
    }
}