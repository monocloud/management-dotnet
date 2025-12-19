namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Client class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchClientRequest>))]
public class PatchClientRequest
{
  /// <summary>
  /// Specifies if client is enabled.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Specifies the preferred application type
  /// </summary>
  public Optional<ApplicationTypes> AppType { get; set; }

  /// <summary>
  /// Specifies the preferred technology type
  /// </summary>
  public Optional<TechTypes> TechType { get; set; }

  /// <summary>
  /// If set to false, no client secret is needed to request tokens at the token endpoint
  /// </summary>
  public Optional<bool> RequireClientSecret { get; set; }

  /// <summary>
  /// The name of the client
  /// </summary>
  public Optional<string> ClientName { get; set; }

  /// <summary>
  /// A brief description of the client.
  /// </summary>
  public Optional<string?> Description { get; set; }

  /// <summary>
  /// URI for providing further information about client
  /// </summary>
  public Optional<string?> ClientUri { get; set; }

  /// <summary>
  /// URI to client logo
  /// </summary>
  public Optional<string?> LogoUri { get; set; }

  /// <summary>
  /// Specifies whether a consent screen is required to be shown
  /// </summary>
  public Optional<bool> RequireConsent { get; set; }

  /// <summary>
  /// Specifies whether to show the consent screen when the offline_access scope is requested (regardless of RememberConsent)
  /// </summary>
  public Optional<bool> AlwaysRequireConsentForOfflineAccess { get; set; }

  /// <summary>
  /// Specifies whether user can choose to store consent decisions
  /// </summary>
  public Optional<RememberConsentTypes> RememberConsent { get; set; }

  /// <summary>
  /// Specifies whether or not the user is allowed to select the scopes on the consent screen
  /// </summary>
  public Optional<bool> ShowConsentScopeSelection { get; set; }

  /// <summary>
  /// When requesting both an id token and access token, should the user claims always be added to the id token instead of requiring the client to use the userinfo endpoint.
  /// </summary>
  public Optional<bool> AlwaysIncludeUserClaimsInIdToken { get; set; }

  /// <summary>
  /// Specifies the allowed grant types (legal combinations is required).
  /// </summary>
  public Optional<List<GrantTypes>> AllowedGrantTypes { get; set; }

  /// <summary>
  /// Specifies whether a proof key is required for authorization code based token requests
  /// </summary>
  public Optional<bool> RequirePkce { get; set; }

  /// <summary>
  /// Specifies whether a proof key can be sent using plain method (not recommended to be set to &#x60;true&#x60;)
  /// </summary>
  public Optional<bool> AllowPlainTextPkce { get; set; }

  /// <summary>
  /// Specifies whether this client needs to wrap the authorize request parameters in a JWT
  /// </summary>
  public Optional<bool> RequireRequestObject { get; set; }

  /// <summary>
  /// Specifies whether Pushed Authorization Requests are required for authorization.
  /// </summary>
  public Optional<bool> RequirePushedAuthorizationRequests { get; set; }

  /// <summary>
  /// Specifies whether the client will be able to use any redirect uri  and not be restricted to the whitelisted ones.
  /// </summary>
  public Optional<bool> AllowAnyPushedAuthorizationRedirectUri { get; set; }

  /// <summary>
  /// Specifies the expiration period of the Authorization Request in seconds.
  /// </summary>
  public Optional<int> AuthorizationRequestLifetime { get; set; }

  /// <summary>
  /// Controls whether access tokens are transmitted via the browser for this client. This can prevent accidental leakage of access tokens when multiple response types are allowed.
  /// </summary>
  public Optional<bool> AllowAccessTokensViaBrowser { get; set; }

  /// <summary>
  /// Specifies allowed URIs to return tokens or authorization codes to
  /// </summary>
  public Optional<List<string>> RedirectUris { get; set; }

  /// <summary>
  /// Specifies allowed URIs to redirect to after logout
  /// </summary>
  public Optional<List<string>> PostLogoutRedirectUris { get; set; }

  /// <summary>
  /// Specifies logout URI at client for HTTP front-channel based logout.
  /// </summary>
  public Optional<string?> FrontChannelLogoutUri { get; set; }

  /// <summary>
  /// Specifies if the user&#39;s session id should be sent to the FrontChannelLogoutUri
  /// </summary>
  public Optional<bool> FrontChannelLogoutSessionRequired { get; set; }

  /// <summary>
  /// Specifies logout URI at client for HTTP back-channel based logout.
  /// </summary>
  public Optional<string?> BackChannelLogoutUri { get; set; }

  /// <summary>
  /// Specifies if the user&#39;s session id should be sent to the BackChannelLogoutUri
  /// </summary>
  public Optional<bool> BackChannelLogoutSessionRequired { get; set; }

  /// <summary>
  /// Specifies whether to bind the tokens issued for the client with the user session. If set to true tokens / grants associated with the session will be invalidated when the user logs out or when the session expires
  /// </summary>
  public Optional<bool> BindTokensToSession { get; set; }

  /// <summary>
  /// Specifies whether the client can request refresh tokens (by requesting the offline_access scope)
  /// </summary>
  public Optional<bool> AllowOfflineAccess { get; set; }

  /// <summary>
  /// Specifies the identity scopes the client is allowed to access (by default a client has no access to any resources)
  /// </summary>
  public Optional<List<string>> AllowedIdentityScopes { get; set; }

  /// <summary>
  /// Lifetime of identity token in seconds
  /// </summary>
  public Optional<int> IdentityTokenLifetime { get; set; }

  /// <summary>
  /// Lifetime of access token in seconds
  /// </summary>
  public Optional<int> AccessTokenLifetime { get; set; }

  /// <summary>
  /// Lifetime of authorization code in seconds
  /// </summary>
  public Optional<int> AuthorizationCodeLifetime { get; set; }

  /// <summary>
  /// Lifetime of a user consent in seconds. Set to 0 for no expiration.
  /// </summary>
  public Optional<int> ConsentLifetime { get; set; }

  /// <summary>
  /// Maximum lifetime of a refresh token in seconds
  /// </summary>
  public Optional<int> AbsoluteRefreshTokenLifetime { get; set; }

  /// <summary>
  /// Sliding lifetime of a refresh token in seconds
  /// </summary>
  public Optional<int> SlidingRefreshTokenLifetime { get; set; }

  /// <summary>
  /// Specified the validity of a refresh token
  /// </summary>
  public Optional<RefreshTokenUsageTypes> RefreshTokenUsage { get; set; }

  /// <summary>
  /// Specifies a value indicating whether the access token (and its claims) should be updated on a refresh token request
  /// </summary>
  public Optional<bool> UpdateAccessTokenClaimsOnRefresh { get; set; }

  /// <summary>
  /// Specifies whether the access token scopes should include the offline_access scope when the client requests it.
  /// </summary>
  public Optional<bool> EmitOfflineAccessScopeInAccessToken { get; set; }

  /// <summary>
  /// Specifies how the refresh token expires
  /// </summary>
  public Optional<RefreshTokenExpirationTypes> RefreshTokenExpiration { get; set; }

  /// <summary>
  /// Specifies whether the access token is a reference token or a self contained JWT token.
  /// </summary>
  public Optional<AccessTokenTypes> AccessTokenType { get; set; }

  /// <summary>
  /// Specifies which authenticators can be used with this client (if list is empty all authenticators are allowed)
  /// </summary>
  public Optional<List<Authenticators>> AuthenticatorRestrictions { get; set; }

  /// <summary>
  /// Specifies whether JWT access tokens should include an identifier
  /// </summary>
  public Optional<bool> IncludeJwtId { get; set; }

  /// <summary>
  /// Allows settings claims for the client (will be included in the access token).
  /// </summary>
  public Optional<Dictionary<string, object>> Claims { get; set; }

  /// <summary>
  /// Specifies whether client claims should be always included in the access tokens - or only for client credentials flow.
  /// </summary>
  public Optional<bool> AlwaysSendClientClaims { get; set; }

  /// <summary>
  /// If set, the client claim will be prefixed with this value
  /// </summary>
  public Optional<string> ClientClaimsPrefix { get; set; }

  /// <summary>
  /// The allowed CORS origins for JavaScript clients.
  /// </summary>
  public Optional<List<string>> AllowedCorsOrigins { get; set; }

  /// <summary>
  /// The maximum duration (in seconds) since the last time the user authenticated. You can adjust the lifetime of a session token to control when and how often a user is required to reenter credentials instead of being silently authenticated, when using a web application. Set to 0 for no restriction.
  /// </summary>
  public Optional<int> UserSsoLifetime { get; set; }

  /// <summary>
  /// Specifies the type of code that will be generated for the device code flow
  /// </summary>
  public Optional<DeviceFlowCodeTypes> UserCodeType { get; set; }

  /// <summary>
  /// Specifies the length of code that will be generated for the device code flow
  /// </summary>
  public Optional<int> DeviceCodeLength { get; set; }

  /// <summary>
  /// Specifies the device code lifetime.
  /// </summary>
  public Optional<int> DeviceCodeLifetime { get; set; }
}


