namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Authentication Options Request: Used to update the authentication configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAuthenticationOptionsRequest>))]
public class PatchAuthenticationOptionsRequest
{
  /// <summary>
  /// Pushed Authorization Request Options
  /// </summary>
  public Optional<PatchPushedAuthorizationOptionsRequest> PushedAuthorization { get; set; }

  /// <summary>
  /// Account Protection Options
  /// </summary>
  public Optional<PatchAccountProtectionOptionsRequest> AccountProtection { get; set; }

  /// <summary>
  /// Authenticators Options
  /// </summary>
  public Optional<PatchAuthenticatorOptionsRequest> Authenticators { get; set; }

  /// <summary>
  /// Identifiers Options
  /// </summary>
  public Optional<PatchIdentifierOptionsRequest> Identifiers { get; set; }

  /// <summary>
  /// Recovery Methods Options
  /// </summary>
  public Optional<PatchRecoveryMethodsOptionsRequest> RecoveryMethods { get; set; }

  /// <summary>
  /// Session Options
  /// </summary>
  public Optional<PatchSessionOptionsRequest> Session { get; set; }

  /// <summary>
  /// Logout Options
  /// </summary>
  public Optional<PatchLogoutOptionsRequest> Logout { get; set; }

  /// <summary>
  /// Sign-up Options
  /// </summary>
  public Optional<PatchSignUpOptionsRequest> SignUp { get; set; }
}


