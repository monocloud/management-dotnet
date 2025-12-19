namespace MonoCloud.Management.Identity.Models;

/// <summary>
/// The Reset Password Request.
/// </summary>
public class ResetPasswordRequest
{
  /// <summary>
  /// Specifies whether the reset link should be automatically delivered to the user via email.
  /// </summary>
  public bool? SendEmail { get; set; }

  /// <summary>
  /// Lifetime of the reset link in seconds; defaults to system configuration if omitted.
  /// </summary>
  public int? Expiry { get; set; }
}


