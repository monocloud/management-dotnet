namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Client Request: Used to update one or more properties of an existing client.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchClientRequest>))]
public class PatchClientRequest
{
  /// <summary>
  /// Indicates whether the client is enabled.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Preferred application type for the client.
  /// </summary>
  public Optional<ApplicationTypes> AppType { get; set; }

  /// <summary>
  /// Preferred technology stack for the client.
  /// </summary>
  public Optional<TechTypes> TechType { get; set; }

  /// <summary>
  /// Requires confidential clients to present a client secret when requesting tokens.
  /// </summary>
  /// <warning>Only disable for public clients (e.g., SPA / mobile).</warning>
  public Optional<bool> RequireClientSecret { get; set; }

  /// <summary>
  /// Human-readable name for the client application, displayed to users on the login and consent screens.
  /// </summary>
  public Optional<string> ClientName { get; set; }

  /// <summary>
  /// Description that explains the purpose of the client application.
  /// </summary>
  public Optional<string?> Description { get; set; }

  /// <summary>
  /// Public URL that provides additional information about the client application.
  /// </summary>
  public Optional<string?> ClientUri { get; set; }

  /// <summary>
  /// URL of the client application logo, displayed on the consent screen to help users identify the application.
  /// </summary>
  public Optional<string?> LogoUri { get; set; }

  /// <summary>
  /// Controls whether users are prompted to review and approve requested permissions.
  /// </summary>
  /// <note>Secure+ subscription required to use consents.</note>
  public Optional<bool> RequireConsent { get; set; }

  /// <summary>
  /// Always prompts users for consent when requesting offline (refresh token) access.
  /// </summary>
  /// <note>This setting applies even if the user previously chose to remember their consent.</note>
  public Optional<bool> AlwaysRequireConsentForOfflineAccess { get; set; }

  /// <summary>
  /// Controls how consent decisions are remembered for future sign-ins.
  /// </summary>
  public Optional<RememberConsentTypes> RememberConsent { get; set; }

  /// <summary>
  /// Allows end users to choose which requested scopes to grant on the consent screen.
  /// </summary>
  public Optional<bool> ShowConsentScopeSelection { get; set; }

  /// <summary>
  /// Always embeds user claims in the ID token instead of requiring calls to the userinfo endpoint.
  /// </summary>
  /// <note>Enabling this increases the ID token size and may expose more user data to applications than necessary.</note>
  public Optional<bool> AlwaysIncludeUserClaimsInIdToken { get; set; }

  /// <summary>
  /// Defines which OAuth / OIDC grant types this client is permitted to use.
  /// </summary>
  /// <note>Only valid and secure grant combinations are supported.</note>
  public Optional<List<GrantTypes>> AllowedGrantTypes { get; set; }

  /// <summary>
  /// Requires Proof Key for Code Exchange (PKCE) for authorization code flows.
  /// </summary>
  /// <note>Strongly recommended for public clients such as SPAs and mobile applications.</note>
  public Optional<bool> RequirePkce { get; set; }

  /// <summary>
  /// Allows Proof Key for Code Exchange (PKCE) verification using the plain (unhashed) method.
  /// </summary>
  /// <warning>Use only for legacy compatibility — strongly discouraged for production.</warning>
  public Optional<bool> AllowPlainTextPkce { get; set; }

  /// <summary>
  /// Requires authorization requests to be sent as signed JWT request objects.
  /// </summary>
  /// <note>Secure+ subscription required to use JWT request objects (JAR).</note>
  public Optional<bool> RequireRequestObject { get; set; }

  /// <summary>
  /// Requires clients to use Pushed Authorization Requests (PAR) instead of sending parameters directly to the authorization endpoint.
  /// </summary>
  /// <note>Secure+ subscription required to use Pushed Authorization Requests (PAR).</note>
  public Optional<bool> RequirePushedAuthorizationRequests { get; set; }

  /// <summary>
  /// Allows the client to use any redirect URI when using Pushed Authorization Requests (PAR), instead of being limited to the configured redirect URI list.
  /// </summary>
  public Optional<bool> AllowAnyPushedAuthorizationRedirectUri { get; set; }

  /// <summary>
  /// Lifetime of the authorization request (in seconds). Controls how long the request data is considered valid during the authorization flow.
  /// </summary>
  public Optional<int> AuthorizationRequestLifetime { get; set; }

  /// <summary>
  /// Controls whether access tokens may be transmitted via the browser for this client.
  /// </summary>
  /// <warning>Enable only when absolutely necessary. Returning access tokens to the browser increases the risk of leakage through logs, plugins, redirects, or malicious scripts. Recommended to keep disabled and prefer the Authorization Code + PKCE flow.</warning>
  public Optional<bool> AllowAccessTokensViaBrowser { get; set; }

  /// <summary>
  /// List of approved redirect URIs where authorization codes or tokens may be sent.
  /// </summary>
  /// <note>Only exact, fully-qualified matches are allowed.</note>
  public Optional<List<string>> RedirectUris { get; set; }

  /// <summary>
  /// List of approved URIs users can be redirected to after a successful logout.
  /// </summary>
  /// <note>Only exact, fully-qualified matches are allowed.</note>
  public Optional<List<string>> PostLogoutRedirectUris { get; set; }

  /// <summary>
  /// Browser-based (front-channel) endpoint on the client that receives user logout notifications from MonoCloud.
  /// </summary>
  /// <note>Pro plan subscription required to use front-channel logout.</note>
  public Optional<string?> FrontChannelLogoutUri { get; set; }

  /// <summary>
  /// Indicates whether the user’s session identifier should be included when invoking the front-channel logout URI.
  /// </summary>
  public Optional<bool> FrontChannelLogoutSessionRequired { get; set; }

  /// <summary>
  /// Server-side (back-channel) endpoint that MonoCloud calls to notify the application of a user logout.
  /// </summary>
  /// <note>Secure+ subscription required to use back-channel logout.</note>
  public Optional<string?> BackChannelLogoutUri { get; set; }

  /// <summary>
  /// Indicates whether the user’s session identifier should be included when invoking the back-channel logout URI.
  /// </summary>
  public Optional<bool> BackChannelLogoutSessionRequired { get; set; }

  /// <summary>
  /// Binds issued tokens to the user&#39;s session. When enabled, all tokens and grants are automatically revoked when the user signs out or the session expires.
  /// </summary>
  /// <note>ScaleX subscription required to use session binding.</note>
  public Optional<bool> BindTokensToSession { get; set; }

  /// <summary>
  /// Allows the client to obtain refresh tokens using the &#x60;offline_access&#x60; scope.
  /// </summary>
  /// <note>Use only for trusted applications that can securely store long-lived tokens.</note>
  public Optional<bool> AllowOfflineAccess { get; set; }

  /// <summary>
  /// Defines the approved identity scopes that this client is authorized to request.
  /// </summary>
  public Optional<List<string>> AllowedIdentityScopes { get; set; }

  /// <summary>
  /// Specifies how long an ID token remains valid (in seconds).
  /// </summary>
  public Optional<int> IdentityTokenLifetime { get; set; }

  /// <summary>
  /// Specifies how long an access token remains valid (in seconds).
  /// </summary>
  public Optional<int> AccessTokenLifetime { get; set; }

  /// <summary>
  /// Specifies how long an authorization code remains valid (in seconds).
  /// </summary>
  public Optional<int> AuthorizationCodeLifetime { get; set; }

  /// <summary>
  /// Specifies the validity period for stored user consent (in seconds). Set to &#x60;0&#x60; to allow consent to remain valid indefinitely.
  /// </summary>
  public Optional<int> ConsentLifetime { get; set; }

  /// <summary>
  /// Specifies the maximum lifetime of a refresh token (in seconds), regardless of how often it is used.
  /// </summary>
  /// <note>ScaleX subscription required to configure refresh token lifetimes longer than a month.</note>
  public Optional<int> AbsoluteRefreshTokenLifetime { get; set; }

  /// <summary>
  /// Defines the sliding expiration window for refresh tokens (in seconds). Token expiry is extended on each valid refresh, subject to the absolute refresh token lifetime.
  /// </summary>
  public Optional<int> SlidingRefreshTokenLifetime { get; set; }

  /// <summary>
  /// Controls whether refresh tokens are single-use (rotated) or reusable.
  /// </summary>
  public Optional<RefreshTokenUsageTypes> RefreshTokenUsage { get; set; }

  /// <summary>
  /// Controls whether access token claims are recalculated and reissued when refreshing a token.
  /// </summary>
  public Optional<bool> UpdateAccessTokenClaimsOnRefresh { get; set; }

  /// <summary>
  /// Includes the &#x60;offline_access&#x60; scope in issued access tokens when requested by the client.
  /// </summary>
  public Optional<bool> EmitOfflineAccessScopeInAccessToken { get; set; }

  /// <summary>
  /// Controls whether refresh tokens expire at a fixed time or are extended with continued use.
  /// </summary>
  public Optional<RefreshTokenExpirationTypes> RefreshTokenExpiration { get; set; }

  /// <summary>
  /// Specifies whether access tokens are issued as self-contained JWTs or as opaque references stored server-side.
  /// </summary>
  /// <note>ScaleX subscription required to use reference tokens. Reference tokens improve revocation control and reduce exposure risk, but require token introspection by protected resources.</note>
  public Optional<AccessTokenTypes> AccessTokenType { get; set; }

  /// <summary>
  /// Defines the authenticators users may use to sign in with this client. Leave empty to inherit the global authenticator policy.
  /// </summary>
  /// <note>Pro plan subscription required to enable authenticator restrictions.</note>
  public Optional<List<Authenticators>> AuthenticatorRestrictions { get; set; }

  /// <summary>
  /// Determines whether issued access tokens include a unique token identifier (jti).
  /// </summary>
  /// <note>Recommended for auditing, correlation, and replay-detection.</note>
  public Optional<bool> IncludeJwtId { get; set; }

  /// <summary>
  /// Defines custom claims issued to this client and embedded into access tokens for downstream APIs and resources.
  /// </summary>
  public Optional<Dictionary<string, object>> Claims { get; set; }

  /// <summary>
  /// Controls whether client claims are always emitted in access tokens, or only when using the client credentials flow.
  /// </summary>
  public Optional<bool> AlwaysSendClientClaims { get; set; }

  /// <summary>
  /// Configures a prefix for client claims, helping avoid naming collisions across tokens and downstream APIs.
  /// </summary>
  public Optional<string?> ClientClaimsPrefix { get; set; }

  /// <summary>
  /// Configures the set of trusted origins permitted to perform cross-origin requests for this client.
  /// </summary>
  public Optional<List<string>> AllowedCorsOrigins { get; set; }

  /// <summary>
  /// Maximum allowed SSO duration (in seconds). After this window, users must sign in again to confirm identity. Set to &#x60;0&#x60; to disable the limit.
  /// </summary>
  public Optional<int> UserSsoLifetime { get; set; }

  /// <summary>
  /// Specifies the length of the user verification code generated for the device flow.
  /// </summary>
  public Optional<int> DeviceCodeLength { get; set; }

  /// <summary>
  /// Specifies the lifetime of the device authorization code (in seconds).
  /// </summary>
  public Optional<int> DeviceCodeLifetime { get; set; }
}


