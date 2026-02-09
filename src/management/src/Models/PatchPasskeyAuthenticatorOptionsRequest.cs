namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Passkey Authenticator Options Request: Used to partially update passkey-based authentication configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchPasskeyAuthenticatorOptionsRequest>))]
public class PatchPasskeyAuthenticatorOptionsRequest
{
  /// <summary>
  /// Specifies whether users can sign in using passkeys.
  /// </summary>
  /// <note>Pro plan subscription required to use Passkeys.</note>
  public Optional<bool> EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether new users can sign up using passkeys.
  /// </summary>
  /// <note>Pro plan subscription required to use Passkeys.</note>
  public Optional<bool> EnableSignUp { get; set; }

  /// <summary>
  /// Specifies whether users should be prompted to enroll a passkey if none exists.
  /// </summary>
  public Optional<bool> PromptEnrollment { get; set; }

  /// <summary>
  /// Specifies whether users should be prompted to enroll a passkey for the current device if no device-specific passkey exists.
  /// </summary>
  public Optional<bool> PromptDeviceEnrollment { get; set; }

  /// <summary>
  /// Specifies whether passkeys can be auto-filled using the identifier field on the sign-in page.
  /// </summary>
  public Optional<bool> EnableAutoComplete { get; set; }

  /// <summary>
  /// Specifies whether the “Continue with Passkey” button is shown on the sign-in page.
  /// </summary>
  public Optional<bool> ShowPasskeyButton { get; set; }
}


