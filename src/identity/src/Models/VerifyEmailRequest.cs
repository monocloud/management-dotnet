namespace MonoCloud.Management.Identity.Models;

/// <summary>
/// The Verify Email Request.
/// </summary>
public class VerifyEmailRequest
{
  /// <summary>
  /// Lifetime of the verification link in seconds; defaults to system configuration if omitted.
  /// </summary>
  public int? Expiry { get; set; }
}


