namespace MonoCloud.Management.Models;

/// <summary>
/// Authentication Options Response: Represents the current authentication configuration for the tenant.
/// </summary>
public class AuthenticationOptions
{
  /// <summary>
  /// Pushed Authorization Request Options
  /// </summary>
  public PushedAuthorizationOptions PushedAuthorization { get; set; }

  /// <summary>
  /// Account Protection Options
  /// </summary>
  public AccountProtectionOptions AccountProtection { get; set; }

  /// <summary>
  /// Authenticators Options
  /// </summary>
  public AuthenticatorOptions Authenticators { get; set; }

  /// <summary>
  /// Identifiers Options
  /// </summary>
  public IdentifierOptions Identifiers { get; set; }

  /// <summary>
  /// Recovery Methods Options
  /// </summary>
  public RecoveryMethodsOptions RecoveryMethods { get; set; }

  /// <summary>
  /// Session Options
  /// </summary>
  public SessionOptions Session { get; set; }

  /// <summary>
  /// Logout Options
  /// </summary>
  public LogoutOptions Logout { get; set; }

  /// <summary>
  /// Sign-up Options
  /// </summary>
  public SignUpOptions SignUp { get; set; }
}


