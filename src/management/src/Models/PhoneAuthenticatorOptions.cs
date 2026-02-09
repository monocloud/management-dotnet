namespace MonoCloud.Management.Models;

/// <summary>
/// Phone Authenticator Options Response: Represents the configuration for phone-based authentication.
/// </summary>
public class PhoneAuthenticatorOptions
{
  /// <summary>
  /// Specifies whether users can sign in using phone-based authentication.
  /// </summary>
  public bool EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether new users can sign up using phone-based authentication.
  /// </summary>
  public bool EnableSignUp { get; set; }

  /// <summary>
  /// Specifies whether users can be automatically provisioned on first successful phone authentication (Just-In-Time provisioning).
  /// </summary>
  public bool EnableJitProvisioning { get; set; }

  /// <summary>
  /// Specifies the validity period of the phone verification code (in seconds).
  /// </summary>
  public int Expiry { get; set; }

  /// <summary>
  /// Specifies the number of digits in the phone verification code.
  /// </summary>
  public int CodeLength { get; set; }
}


