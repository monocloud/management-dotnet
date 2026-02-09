namespace MonoCloud.Management.Models;

/// <summary>
/// Patch LinkedIn Authenticator Options Request: Used to partially update Sign in with LinkedIn configuration and behavior.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchLinkedInAuthenticatorOptionsRequest>))]
public class PatchLinkedInAuthenticatorOptionsRequest
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
  /// The set of scopes requested from the external identity provider during authentication.
  /// </summary>
  public Optional<List<string>> Scopes { get; set; }

  /// <summary>
  /// Specifies whether the &#x60;email_verified&#x60; claim from LinkedIn is trusted.
  /// </summary>
  /// <note>When enabled, MonoCloud skips email verification if LinkedIn reports the email as verified.</note>
  public Optional<bool> TrustEmailVerifiedScope { get; set; }
}


