namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Phone Identifier Options Request: Used to update phone sign-in, sign-up, and verification settings.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchPhoneIdentifierOptionsRequest>))]
public class PatchPhoneIdentifierOptionsRequest
{
  /// <summary>
  /// Specifies whether users can sign in using a phone number.
  /// </summary>
  public Optional<bool> EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether a phone number can be collected during sign-up.
  /// </summary>
  public Optional<bool> ShowAtSignUp { get; set; }

  /// <summary>
  /// Specifies whether a phone number is required during sign-up.
  /// </summary>
  public Optional<bool> RequiredAtSignUp { get; set; }

  /// <summary>
  /// Phone verification configuration applied during sign-up.
  /// </summary>
  public Optional<PatchPhoneIdentifierVerificationOptionsRequest> Verification { get; set; }
}


