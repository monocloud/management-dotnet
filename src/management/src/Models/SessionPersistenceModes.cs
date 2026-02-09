namespace MonoCloud.Management.Models;

/// <summary>
/// The session persistence mode.
/// </summary>
public enum SessionPersistenceModes
{
  /// <summary>
  /// The session is always persisted in accordance with the configured expiration type.
  /// </summary>
  Persistent,

  /// <summary>
  /// The session expires when the browser is closed.
  /// </summary>
  NonPersistent,

  /// <summary>
  /// The session is persisted only if the user chooses to remember the session; otherwise, it expires when the browser is closed.
  /// </summary>
  UserSelected
}


