namespace MonoCloud.Management.Models;

/// <summary>
/// The expiration type.
/// </summary>
public enum ExpirationTypes
{
  /// <summary>
  /// Sessions use a sliding expiration model. Each successful interaction with the authorization server extends the session lifetime (up to the configured absolute session lifetime).
  /// </summary>
  Sliding,

  /// <summary>
  /// Sessions expire at a fixed point in time, based on the configured absolute session lifetime — regardless of user activity.
  /// </summary>
  Absolute
}


