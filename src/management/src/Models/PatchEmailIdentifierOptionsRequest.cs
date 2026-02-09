namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Email Identifier Options Request: Used to update email sign-in, sign-up, and verification settings.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchEmailIdentifierOptionsRequest>))]
public class PatchEmailIdentifierOptionsRequest
{
  /// <summary>
  /// Specifies whether users can sign in using an email address.
  /// </summary>
  public Optional<bool> EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether an email address can be collected during sign-up.
  /// </summary>
  public Optional<bool> ShowAtSignUp { get; set; }

  /// <summary>
  /// Specifies whether an email address is required during sign-up.
  /// </summary>
  public Optional<bool> RequiredAtSignUp { get; set; }

  /// <summary>
  /// Email verification configuration applied during sign-up.
  /// </summary>
  public Optional<PatchEmailIdentifierVerificationOptionsRequest> Verification { get; set; }
}


