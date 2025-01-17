using System.Text.Json.Serialization;

namespace MiniTwitch.Helix.Responses;

public class ActiveExtensions
{
    [JsonPropertyName("data")]
    public ExtensionsData Data { get; init; }

    public record Component(
        [property: JsonPropertyName("active")] bool Active,
        [property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("version")] string Version,
        [property: JsonPropertyName("name")] string Name,
        [property: JsonPropertyName("x")] int X,
        [property: JsonPropertyName("y")] int Y
    );

    public record Panel(
        [property: JsonPropertyName("active")] bool Active,
        [property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("version")] string Version,
        [property: JsonPropertyName("name")] string Name
    );

    public record Overlay(
        [property: JsonPropertyName("active")] bool Active,
        [property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("version")] string Version,
        [property: JsonPropertyName("name")] string Name
    );

    public record ExtensionsData(
        [property: JsonPropertyName("panel")] Dictionary<int, Panel> Panel,
        [property: JsonPropertyName("overlay")] Dictionary<int, Overlay> Overlay,
        [property: JsonPropertyName("component")] Dictionary<int, Component> Component
    );
}