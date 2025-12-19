namespace MonoCloud.Management.Identity.Models;

/// <summary>
/// The Add Email Request.
/// </summary>
public class AddEmailRequest
{
  /// <summary>
  /// The email address to add to the user’s account.
  /// </summary>
  public string Email { get; set; }

  /// <summary>
  /// Indicates whether the email should be marked as verified when added. If false, verification may be required before the email can be used in login or recovery flows.
  /// </summary>
  public bool? IsVerified { get; set; }

  /// <summary>
  /// Skips blacklist validation for the provided email.
  /// </summary>
  public bool? SkipRestrictionChecks { get; set; }
}


