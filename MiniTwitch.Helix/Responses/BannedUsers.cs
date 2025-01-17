using System.Text.Json.Serialization;
using MiniTwitch.Helix.Models;

namespace MiniTwitch.Helix.Responses;

public class BannedUsers : PaginableResponse<BannedUsers.User>
{
    public record User(
        [property: JsonPropertyName("user_id")] long UserId,
        [property: JsonPropertyName("user_login")] string Username,
        [property: JsonPropertyName("user_name")] string UserDisplayName,
        [property: JsonPropertyName("expires_at")] DateTime? ExpiresAt,
        [property: JsonPropertyName("created_at")] DateTime CreatedAt,
        [property: JsonPropertyName("reason")] string Reason,
        [property: JsonPropertyName("moderator_id")] long ModeratorId,
        [property: JsonPropertyName("moderator_login")] string ModeratorName,
        [property: JsonPropertyName("moderator_name")] string ModeratorDisplayName
    );
}