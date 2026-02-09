namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Session Options Request: Used to update the user session configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchSessionOptionsRequest>))]
public class PatchSessionOptionsRequest
{
  /// <summary>
  /// Determines whether the user session is persisted across browser restarts, expires on browser close, or is decided by the user.
  /// </summary>
  public Optional<SessionPersistenceModes> PersistenceMode { get; set; }

  /// <summary>
  /// Determines whether the session expiration is extended on activity (sliding) or expires at a fixed time (absolute).
  /// </summary>
  public Optional<ExpirationTypes> ExpirationType { get; set; }

  /// <summary>
  /// The session lifetime applied when using sliding expiration (in minutes). Each qualifying user interaction renews the session up to the absolute limit.
  /// </summary>
  public Optional<int> SlidingSessionLifetime { get; set; }

  /// <summary>
  /// The maximum session lifetime after which the session expires regardless of activity or expiration type (in minutes).
  /// </summary>
  public Optional<int> AbsoluteSessionLifetime { get; set; }
}


