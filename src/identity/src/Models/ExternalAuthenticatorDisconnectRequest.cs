namespace MonoCloud.Management.Identity.Models;

/// <summary>
/// The External Authenticator Disconnect Request class.
/// </summary>
public class ExternalAuthenticatorDisconnectRequest
{
  /// <summary>
  /// The external authentication provider to disconnect from the user&#39;s account.
  /// </summary>
  public ExternalAuthenticators? Authenticator { get; set; }

  /// <summary>
  /// The identifier assigned to the user by the external provider.
  /// </summary>
  public string ProviderUserId { get; set; }
}


