namespace MonoCloud.Management.Models;

/// <summary>
/// The access token type.
/// </summary>
public enum AccessTokenTypes
{
  /// <summary>
  /// A self-contained JWT access token.
  /// </summary>
  Jwt,

  /// <summary>
  /// An opaque reference token stored and validated server-side.
  /// </summary>
  Reference
}


