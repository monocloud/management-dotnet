namespace MonoCloud.Management.Models;

/// <summary>
/// GitLab Authenticator Options Response: Represents the Sign in with GitLab authentication configuration.
/// </summary>
public class GitLabAuthenticatorOptions
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
  /// The set of scopes requested from the external identity provider during authentication.
  /// </summary>
  public List<string> Scopes { get; set; }

  /// <summary>
  /// Specifies whether the &#x60;email_verified&#x60; claim from GitLab is trusted.
  /// </summary>
  /// <note>When enabled, MonoCloud skips email verification if GitLab reports the email as verified.</note>
  public bool TrustEmailVerifiedScope { get; set; }
}


