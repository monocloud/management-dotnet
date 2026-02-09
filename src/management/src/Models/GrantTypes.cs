namespace MonoCloud.Management.Models;

/// <summary>
/// The OAuth2 / OIDC grant type.
/// </summary>
public enum GrantTypes
{
  /// <summary>
  /// A legacy flow for browser-based applications in which tokens are returned directly from the authorization endpoint.
  /// </summary>
  /// <note>Prefer Authorization Code with PKCE for modern applications.</note>
  Implicit,

  /// <summary>
  /// Combines elements of the implicit and authorization code flows, allowing the client to receive both tokens and an authorization code.
  /// </summary>
  Hybrid,

  /// <summary>
  /// Obtains tokens through a secure back-channel exchange and supports client authentication and PKCE.
  /// </summary>
  AuthorizationCode,

  /// <summary>
  /// Used for machine-to-machine scenarios where tokens are issued to the client itself rather than an end user.
  /// </summary>
  ClientCredentials,

  /// <summary>
  /// A legacy flow that issues tokens using a user’s credentials sent directly to the token endpoint.
  /// </summary>
  /// <note>Prefer Authorization Code with PKCE whenever possible.</note>
  Password,

  /// <summary>
  /// Supports devices with limited input capabilities (TVs, consoles, CLI tools) by allowing users to authenticate on a separate device while the client polls for approval.
  /// </summary>
  DeviceCode
}


