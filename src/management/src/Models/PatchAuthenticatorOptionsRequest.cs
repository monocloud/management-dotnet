namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Authenticator Options Request: Used to partially update the authentication provider configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAuthenticatorOptionsRequest>))]
public class PatchAuthenticatorOptionsRequest
{
  /// <summary>
  /// Determines whether external authentication providers are prioritized over other authenticators during sign-in.
  /// </summary>
  public Optional<bool> ExternalSignInMethodsFirst { get; set; }

  /// <summary>
  /// Defines the ordering of external authentication providers during sign-in.
  /// </summary>
  public Optional<List<ExternalAuthenticators>> ExternalSignInMethodsOrder { get; set; }

  /// <summary>
  /// Password authenticator configuration.
  /// </summary>
  public Optional<PatchPasswordAuthenticatorOptionsRequest> Password { get; set; }

  /// <summary>
  /// Passkey authenticator configuration.
  /// </summary>
  public Optional<PatchPasskeyAuthenticatorOptionsRequest> Passkey { get; set; }

  /// <summary>
  /// Email authenticator configuration.
  /// </summary>
  public Optional<PatchEmailAuthenticatorOptionsRequest> Email { get; set; }

  /// <summary>
  /// Phone authenticator configuration.
  /// </summary>
  public Optional<PatchPhoneAuthenticatorOptionsRequest> Phone { get; set; }

  /// <summary>
  /// Google external identity provider configuration.
  /// </summary>
  public Optional<PatchGoogleAuthenticatorOptionsRequest?> Google { get; set; }

  /// <summary>
  /// Apple external identity provider configuration.
  /// </summary>
  public Optional<PatchAppleAuthenticatorOptionsRequest?> Apple { get; set; }

  /// <summary>
  /// Facebook external identity provider configuration.
  /// </summary>
  public Optional<PatchFacebookAuthenticatorOptionsRequest?> Facebook { get; set; }

  /// <summary>
  /// Microsoft external identity provider configuration.
  /// </summary>
  public Optional<PatchMicrosoftAuthenticatorOptionsRequest?> Microsoft { get; set; }

  /// <summary>
  /// GitHub external identity provider configuration.
  /// </summary>
  public Optional<PatchGitHubAuthenticatorOptionsRequest?> Github { get; set; }

  /// <summary>
  /// GitLab external identity provider configuration.
  /// </summary>
  public Optional<PatchGitLabAuthenticatorOptionsRequest?> Gitlab { get; set; }

  /// <summary>
  /// Discord external identity provider configuration.
  /// </summary>
  public Optional<PatchDiscordAuthenticatorOptionsRequest?> Discord { get; set; }

  /// <summary>
  /// Twitter/X external identity provider configuration.
  /// </summary>
  public Optional<PatchTwitterAuthenticatorOptionsRequest?> Twitter { get; set; }

  /// <summary>
  /// LinkedIn external identity provider configuration.
  /// </summary>
  public Optional<PatchLinkedInAuthenticatorOptionsRequest?> Linkedin { get; set; }

  /// <summary>
  /// Xero external identity provider configuration.
  /// </summary>
  public Optional<PatchXeroAuthenticatorOptionsRequest?> Xero { get; set; }
}


