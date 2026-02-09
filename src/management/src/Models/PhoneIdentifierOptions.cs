namespace MonoCloud.Management.Models;

/// <summary>
/// Phone Identifier Options Response: Represents phone sign-in, sign-up, and verification configuration.
/// </summary>
public class PhoneIdentifierOptions
{
  /// <summary>
  /// Specifies whether users can sign in using a phone number.
  /// </summary>
  public bool EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether a phone number can be collected during sign-up.
  /// </summary>
  public bool ShowAtSignUp { get; set; }

  /// <summary>
  /// Specifies whether a phone number is required during sign-up.
  /// </summary>
  public bool RequiredAtSignUp { get; set; }

  /// <summary>
  /// Phone verification configuration applied during sign-up.
  /// </summary>
  public PhoneIdentifierVerificationOptions Verification { get; set; }
}


