namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Microsoft Authenticator Options Request: Used to partially update Sign in with Microsoft configuration and behavior.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchMicrosoftAuthenticatorOptionsRequest>))]
public class PatchMicrosoftAuthenticatorOptionsRequest
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
  /// Specifies whether email addresses returned by Microsoft should be treated as verified.
  /// </summary>
  /// <note>Microsoft does not provide an explicit email verification claim. When enabled, MonoCloud treats the email provided by Microsoft as verified and skips additional email verification.</note>
  public Optional<bool> TreatEmailAsVerified { get; set; }
}


