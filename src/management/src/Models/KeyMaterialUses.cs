namespace MonoCloud.Management.Models;

/// <summary>
/// The key material usage.
/// </summary>
public enum KeyMaterialUses
{
  /// <summary>
  /// Indicates that the key may be used to cryptographically sign tokens, and may also be used to validate token signatures.
  /// </summary>
  Signing,

  /// <summary>
  /// Indicates that the key may only be used to validate or verify the signatures of existing tokens.
  /// </summary>
  Validation
}


