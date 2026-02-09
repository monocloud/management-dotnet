namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Password Authenticator Options Request: Used to partially update password-based authentication configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchPasswordAuthenticatorOptionsRequest>))]
public class PatchPasswordAuthenticatorOptionsRequest
{
  /// <summary>
  /// Specifies whether users can sign in using password-based authentication.
  /// </summary>
  public Optional<bool> EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether new users can sign up using password-based authentication.
  /// </summary>
  public Optional<bool> EnableSignUp { get; set; }

  /// <summary>
  /// Specifies whether the password is collected on the initial sign-in screen alongside the identifier.
  /// </summary>
  public Optional<bool> PromptPasswordOnInitialScreen { get; set; }

  /// <summary>
  /// Specifies the password expiration interval (in days). When empty, passwords do not expire.
  /// </summary>
  public Optional<int?> Expiry { get; set; }

  /// <summary>
  /// Password strength policy configuration.
  /// </summary>
  /// <note>Pro plan required to customize password strength options.</note>
  public Optional<PatchPasswordStrengthOptionsRequest> Strength { get; set; }

  /// <summary>
  /// Password reuse policy configuration.
  /// </summary>
  public Optional<PatchPasswordReuseOptionsRequest> Reuse { get; set; }
}


