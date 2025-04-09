using System.Text.Json.Serialization;

// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Diablo2BinToTxtConverter
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal sealed record KeyFileStructure
    {
        [JsonPropertyName("id")] public required int Id { get; init; }
        [JsonPropertyName("Key")] public required string Key { get; init; }
    }
}