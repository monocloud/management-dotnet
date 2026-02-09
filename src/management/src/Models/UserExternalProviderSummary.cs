namespace MonoCloud.Management.Models;

/// <summary>
/// External Provider Summary: Represents a linked identity provider account for the user.
/// </summary>
public class UserExternalProviderSummary
{
  /// <summary>
  /// The authenticator associated with this connection.
  /// </summary>
  public ExternalAuthenticators Authenticator { get; set; }

  /// <summary>
  /// The user identifier assigned by the identity provider.
  /// </summary>
  public string ProviderUserId { get; set; }
}


