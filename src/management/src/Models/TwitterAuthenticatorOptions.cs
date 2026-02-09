namespace MonoCloud.Management.Models;

/// <summary>
/// Twitter Authenticator Options Response: Represents the Sign in with Twitter/X authentication configuration.
/// </summary>
public class TwitterAuthenticatorOptions
{
  /// <summary>
  /// Specifies whether users can sign in using this external identity provider.
  /// </summary>
  public bool EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether new users can sign up using this external identity provider.
  /// </summary>
  public bool EnableSignUp { get; set; }

  /// <summary>
  /// Specifies whether MonoCloud-managed client credentials should be used to authenticate with the external identity provider.
  /// </summary>
  public bool UseInternalKeys { get; set; }

  /// <summary>
  /// Specifies whether the user profile should be synchronized from the external provider on each successful sign-in.
  /// </summary>
  public bool SyncUserProfileAlways { get; set; }

  /// <summary>
  /// The client identifier issued by the external identity provider.
  /// </summary>
  public string? ClientId { get; set; }

  /// <summary>
  /// The client secret issued by the external identity provider.
  /// </summary>
  public string? ClientSecret { get; set; }

  /// <summary>
  /// Specifies whether email addresses returned by Twitter/X should be treated as verified.
  /// </summary>
  /// <note>Twitter/X does not provide an explicit email verification claim. When enabled, MonoCloud treats the email provided by Twitter/X as verified and skips additional email verification.</note>
  public bool TreatEmailAsVerified { get; set; }
}


