namespace MonoCloud.Management.Identity.Models;

/// <summary>
/// The Add Phone Request.
/// </summary>
public class AddPhoneRequest
{
  /// <summary>
  /// The phone number to add to the user’s account, provided in E.164 format (e.g., +14085551234).
  /// </summary>
  public string PhoneNumber { get; set; }

  /// <summary>
  /// Indicates whether the phone number should be marked as verified when added. If false, verification may be required before the number can be used in login or recovery flows.
  /// </summary>
  public bool? IsVerified { get; set; }

  /// <summary>
  /// Skips blacklist validation for the provided number.
  /// </summary>
  public bool? SkipRestrictionChecks { get; set; }
}


