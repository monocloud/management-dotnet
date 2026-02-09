namespace MonoCloud.Management.Models;

/// <summary>
/// Passkey Authenticator Options Response: Represents the configuration for passkey-based authentication.
/// </summary>
public class PasskeyAuthenticatorOptions
{
  /// <summary>
  /// Specifies whether users can sign in using passkeys.
  /// </summary>
  /// <note>Pro plan subscription required to use Passkeys.</note>
  public bool EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether new users can sign up using passkeys.
  /// </summary>
  /// <note>Pro plan subscription required to use Passkeys.</note>
  public bool EnableSignUp { get; set; }

  /// <summary>
  /// Specifies whether users should be prompted to enroll a passkey if none exists.
  /// </summary>
  public bool PromptEnrollment { get; set; }

  /// <summary>
  /// Specifies whether users should be prompted to enroll a passkey for the current device if no device-specific passkey exists.
  /// </summary>
  public bool PromptDeviceEnrollment { get; set; }

  /// <summary>
  /// Specifies whether passkeys can be auto-filled using the identifier field on the sign-in page.
  /// </summary>
  public bool EnableAutoComplete { get; set; }

  /// <summary>
  /// Specifies whether the “Continue with Passkey” button is shown on the sign-in page.
  /// </summary>
  public bool ShowPasskeyButton { get; set; }
}


