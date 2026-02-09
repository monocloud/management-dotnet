namespace MonoCloud.Management.Models;

/// <summary>
/// The refresh tokens expiration type.
/// </summary>
public enum RefreshTokenExpirationTypes
{
  /// <summary>
  /// Refresh tokens use a sliding expiration model. Each successful refresh extends the token lifetime (up to the configured absolute refresh token lifetime).
  /// </summary>
  Sliding,

  /// <summary>
  /// Refresh tokens expire at a fixed point in time, based on the configured absolute refresh token lifetime — regardless of usage.
  /// </summary>
  Absolute
}


