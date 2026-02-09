namespace MonoCloud.Management.Models;

/// <summary>
/// Email Identifier Options Response: Represents email sign-in, sign-up, and verification configuration.
/// </summary>
public class EmailIdentifierOptions
{
  /// <summary>
  /// Specifies whether users can sign in using an email address.
  /// </summary>
  public bool EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether an email address can be collected during sign-up.
  /// </summary>
  public bool ShowAtSignUp { get; set; }

  /// <summary>
  /// Specifies whether an email address is required during sign-up.
  /// </summary>
  public bool RequiredAtSignUp { get; set; }

  /// <summary>
  /// Email verification configuration applied during sign-up.
  /// </summary>
  public EmailIdentifierVerificationOptions Verification { get; set; }
}


