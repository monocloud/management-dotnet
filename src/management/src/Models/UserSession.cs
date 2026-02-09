namespace MonoCloud.Management.Models;

/// <summary>
/// User Session: Represents an authentication session for a user.
/// </summary>
public class UserSession
{
  /// <summary>
  /// The unique identifier of the user session.
  /// </summary>
  public string SessionId { get; set; }

  /// <summary>
  /// The list of client identifiers associated with this session.
  /// </summary>
  public List<string> ClientIds { get; set; }

  /// <summary>
  /// Specifies the time at which the session was initiated (in Epoch).
  /// </summary>
  public DateTime InitiatedAt { get; set; }

  /// <summary>
  /// Specifies the time at which the session is scheduled to expire (in Epoch).
  /// </summary>
  public DateTime ExpiresAt { get; set; }

  /// <summary>
  /// Specifies the time at which the session was last updated (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }

  /// <summary>
  /// The most recent metadata recorded for this session.
  /// </summary>
  public UserSessionMetadata LastMetadata { get; set; }
}


