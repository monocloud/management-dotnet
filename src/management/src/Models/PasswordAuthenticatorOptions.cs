namespace MonoCloud.Management.Models;

/// <summary>
/// Password Authenticator Options Response: Represents the configuration for password-based authentication.
/// </summary>
public class PasswordAuthenticatorOptions
{
  /// <summary>
  /// Specifies whether users can sign in using password-based authentication.
  /// </summary>
  public bool EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether new users can sign up using password-based authentication.
  /// </summary>
  public bool EnableSignUp { get; set; }

  /// <summary>
  /// Specifies whether the password is collected on the initial sign-in screen alongside the identifier.
  /// </summary>
  public bool PromptPasswordOnInitialScreen { get; set; }

  /// <summary>
  /// Specifies the password expiration interval (in days). When empty, passwords do not expire.
  /// </summary>
  public int? Expiry { get; set; }

  /// <summary>
  /// Password strength policy configuration.
  /// </summary>
  public PasswordStrengthOptions Strength { get; set; }

  /// <summary>
  /// Password reuse policy configuration.
  /// </summary>
  public PasswordReuseOptions Reuse { get; set; }
}


