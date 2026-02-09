namespace MonoCloud.Management.Models;

/// <summary>
/// Add Phone Request: Used to add a new phone number for a user account.
/// </summary>
public class AddPhoneRequest
{
  /// <summary>
  /// The phone number to add to the user’s account in E.164 format.
  /// </summary>
  public string PhoneNumber { get; set; }

  /// <summary>
  /// Indicates whether the phone number should be marked as verified when added. Verification may be required before the number can be used in login or recovery flows.
  /// </summary>
  public bool? IsVerified { get; set; }

  /// <summary>
  /// Allows bypassing blacklist validation for the provided phone number.
  /// </summary>
  public bool? SkipRestrictionChecks { get; set; }
}


