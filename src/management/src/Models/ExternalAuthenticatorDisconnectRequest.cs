namespace MonoCloud.Management.Models;

/// <summary>
/// External Authenticator Disconnect Request: Removes an existing external identity provider connection from a user account.
/// </summary>
public class ExternalAuthenticatorDisconnectRequest
{
  /// <summary>
  /// The external authentication provider to disconnect from the user account.
  /// </summary>
  public ExternalAuthenticators? Authenticator { get; set; }

  /// <summary>
  /// The user identifier assigned by the external authentication provider.
  /// </summary>
  public string ProviderUserId { get; set; }
}


