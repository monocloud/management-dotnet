namespace MonoCloud.Management.Models;

/// <summary>
/// Reset Password Request: Defines the options used to initiate a password reset flow for a user.
/// </summary>
public class ResetPasswordRequest
{
  /// <summary>
  /// A flag indicating whether the password reset link should be automatically delivered to the user&#39;s email address.
  /// </summary>
  public bool? SendEmail { get; set; }

  /// <summary>
  /// Lifetime of the password reset link (in seconds). Defaults to the system configuration when omitted.
  /// </summary>
  public int? Expiry { get; set; }
}


