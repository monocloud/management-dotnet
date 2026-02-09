namespace MonoCloud.Management.Models;

/// <summary>
/// Email Authenticator Options Response: Represents the configuration for email-based authentication.
/// </summary>
public class EmailAuthenticatorOptions
{
  /// <summary>
  /// Specifies whether users can sign in using email-based authentication.
  /// </summary>
  public bool EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether new users can sign up using email-based authentication.
  /// </summary>
  public bool EnableSignUp { get; set; }

  /// <summary>
  /// Specifies whether users can be automatically provisioned on first successful email authentication (Just-In-Time provisioning).
  /// </summary>
  public bool EnableJitProvisioning { get; set; }

  /// <summary>
  /// Specifies the verification mechanism used for email authentication (link, code, or both).
  /// </summary>
  public VerificationTypes VerificationType { get; set; }

  /// <summary>
  /// Specifies whether the authentication flow can be resumed in a different browser or device than where it was initiated.
  /// </summary>
  public bool AllowCrossBrowser { get; set; }

  /// <summary>
  /// Specifies the validity period of the email verification link or code (in seconds).
  /// </summary>
  public int Expiry { get; set; }

  /// <summary>
  /// Specifies the number of digits in the email verification code.
  /// </summary>
  /// <note>Only applicable when the verification type includes code-based verification.</note>
  public int CodeLength { get; set; }
}


