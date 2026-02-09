namespace MonoCloud.Management.Models;

/// <summary>
/// The refresh tokens usage type.
/// </summary>
public enum RefreshTokenUsageTypes
{
  /// <summary>
  /// The same refresh token can be used repeatedly to obtain new tokens.
  /// </summary>
  Reuse,

  /// <summary>
  /// A new refresh token is issued on every refresh, and the previous one becomes invalid.
  /// </summary>
  OneTimeOnly
}


