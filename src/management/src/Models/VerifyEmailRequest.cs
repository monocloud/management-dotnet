namespace MonoCloud.Management.Models;

/// <summary>
/// Verify Email Request: Used to generate an email verification link.
/// </summary>
public class VerifyEmailRequest
{
  /// <summary>
  /// Lifetime of the verification link (in seconds). Defaults to the system configuration when omitted.
  /// </summary>
  public int? Expiry { get; set; }
}


