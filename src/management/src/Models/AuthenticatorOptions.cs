namespace MonoCloud.Management.Models;

/// <summary>
/// Authenticator Options Response: Defines how users can authenticate, including password, passkeys, and external identity providers.
/// </summary>
public class AuthenticatorOptions
{
  /// <summary>
  /// Determines whether external authentication providers are prioritized over other authenticators during sign-in.
  /// </summary>
  public bool ExternalSignInMethodsFirst { get; set; }

  /// <summary>
  /// Defines the ordering of external authentication providers during sign-in.
  /// </summary>
  public List<ExternalAuthenticators> ExternalSignInMethodsOrder { get; set; }

  /// <summary>
  /// Password authenticator configuration.
  /// </summary>
  public PasswordAuthenticatorOptions Password { get; set; }

  /// <summary>
  /// Passkey authenticator configuration.
  /// </summary>
  public PasskeyAuthenticatorOptions Passkey { get; set; }

  /// <summary>
  /// Email authenticator configuration.
  /// </summary>
  public EmailAuthenticatorOptions Email { get; set; }

  /// <summary>
  /// Phone authenticator configuration.
  /// </summary>
  public PhoneAuthenticatorOptions Phone { get; set; }

  /// <summary>
  /// Google external identity provider configuration.
  /// </summary>
  public GoogleAuthenticatorOptions? Google { get; set; }

  /// <summary>
  /// Apple external identity provider configuration.
  /// </summary>
  public AppleAuthenticatorOptions? Apple { get; set; }

  /// <summary>
  /// Facebook external identity provider configuration.
  /// </summary>
  public FacebookAuthenticatorOptions? Facebook { get; set; }

  /// <summary>
  /// Microsoft external identity provider configuration.
  /// </summary>
  public MicrosoftAuthenticatorOptions? Microsoft { get; set; }

  /// <summary>
  /// GitHub external identity provider configuration.
  /// </summary>
  public GitHubAuthenticatorOptions? Github { get; set; }

  /// <summary>
  /// GitLab external identity provider configuration.
  /// </summary>
  public GitLabAuthenticatorOptions? Gitlab { get; set; }

  /// <summary>
  /// Discord external identity provider configuration.
  /// </summary>
  public DiscordAuthenticatorOptions? Discord { get; set; }

  /// <summary>
  /// Twitter/X external identity provider configuration.
  /// </summary>
  public TwitterAuthenticatorOptions? Twitter { get; set; }

  /// <summary>
  /// LinkedIn external identity provider configuration.
  /// </summary>
  public LinkedInAuthenticatorOptions? Linkedin { get; set; }

  /// <summary>
  /// Xero external identity provider configuration.
  /// </summary>
  public XeroAuthenticatorOptions? Xero { get; set; }
}


