namespace MonoCloud.Management.Models;

/// <summary>
/// The verification type.
/// </summary>
public enum VerificationTypes
{
  /// <summary>
  /// Verification is performed using a one-time code.
  /// </summary>
  Code,

  /// <summary>
  /// Verification is performed using a secure verification link.
  /// </summary>
  Link,

  /// <summary>
  /// Verification can be performed using either a code or a link.
  /// </summary>
  Both
}


