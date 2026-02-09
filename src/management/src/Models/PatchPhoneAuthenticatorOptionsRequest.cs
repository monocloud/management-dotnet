namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Phone Authenticator Options Request: Used to partially update phone-based authentication configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchPhoneAuthenticatorOptionsRequest>))]
public class PatchPhoneAuthenticatorOptionsRequest
{
  /// <summary>
  /// Specifies whether users can sign in using phone-based authentication.
  /// </summary>
  public Optional<bool> EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether new users can sign up using phone-based authentication.
  /// </summary>
  public Optional<bool> EnableSignUp { get; set; }

  /// <summary>
  /// Specifies whether users can be automatically provisioned on first successful phone authentication (Just-In-Time provisioning).
  /// </summary>
  public Optional<bool> EnableJitProvisioning { get; set; }

  /// <summary>
  /// Specifies the validity period of the phone verification code (in seconds).
  /// </summary>
  /// <note>Pro plan required to customize the expiry.</note>
  public Optional<int> Expiry { get; set; }

  /// <summary>
  /// Specifies the number of digits in the phone verification code.
  /// </summary>
  /// <note>Pro plan required to customize the code length.</note>
  public Optional<int> CodeLength { get; set; }
}


