using System.Text.Json.Serialization;
using MiniTwitch.Helix.Models;

namespace MiniTwitch.Helix.Responses;

public class ExtensionSecrets : BaseResponse<ExtensionSecrets.Info>
{
    public record Info(
        [property: JsonPropertyName("format_version")] int FormatVersion,
        [property: JsonPropertyName("secrets")] IReadOnlyList<Secret> Secrets
    );

    public record Secret(
        [property: JsonPropertyName("content")] string Content,
        [property: JsonPropertyName("active_at")] DateTime ActiveAt,
        [property: JsonPropertyName("expires_at")] DateTime ExpiresAt
    );
}