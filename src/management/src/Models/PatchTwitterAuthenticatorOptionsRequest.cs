namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Twitter Authenticator Options Request: Used to partially update Sign in with Twitter/X configuration and behavior.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchTwitterAuthenticatorOptionsRequest>))]
public class PatchTwitterAuthenticatorOptionsRequest
{
  /// <summary>
  /// Specifies whether users can sign in using this external identity provider.
  /// </summary>
  public Optional<bool> EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether new users can sign up using this external identity provider.
  /// </summary>
  public Optional<bool> EnableSignUp { get; set; }

  /// <summary>
  /// Specifies whether MonoCloud-managed client credentials should be used to authenticate with the external identity provider.
  /// </summary>
  public Optional<bool> UseInternalKeys { get; set; }

  /// <summary>
  /// Specifies whether the user profile should be synchronized from the external provider on each successful sign-in.
  /// </summary>
  public Optional<bool> SyncUserProfileAlways { get; set; }

  /// <summary>
  /// The client identifier issued by the external identity provider.
  /// </summary>
  public Optional<string?> ClientId { get; set; }

  /// <summary>
  /// The client secret issued by the external identity provider.
  /// </summary>
  public Optional<string?> ClientSecret { get; set; }

  /// <summary>
  /// Specifies whether email addresses returned by Twitter/X should be treated as verified.
  /// </summary>
  /// <note>Twitter/X does not provide an explicit email verification claim. When enabled, MonoCloud treats the email provided by Twitter/X as verified and skips additional email verification.</note>
  public Optional<bool> TreatEmailAsVerified { get; set; }
}


