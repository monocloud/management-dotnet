namespace MonoCloud.Management.Models;

/// <summary>
/// The log event target type.
/// </summary>
public enum TargetTypes
{
  /// <summary>
  /// A user account.
  /// </summary>
  User,

  /// <summary>
  /// A tenant.
  /// </summary>
  Tenant,

  /// <summary>
  /// A tenant-level key.
  /// </summary>
  TenantKey,

  /// <summary>
  /// A subscription.
  /// </summary>
  Subscription,

  /// <summary>
  /// A client application.
  /// </summary>
  Client,

  /// <summary>
  /// A client secret.
  /// </summary>
  ClientSecret,

  /// <summary>
  /// A group.
  /// </summary>
  Group,

  /// <summary>
  /// A user consent record.
  /// </summary>
  UserConsent,

  /// <summary>
  /// A user identifier.
  /// </summary>
  UserIdentifier,

  /// <summary>
  /// An authenticator.
  /// </summary>
  Authenticator,

  /// <summary>
  /// An IP address.
  /// </summary>
  IpAddress,

  /// <summary>
  /// A user session.
  /// </summary>
  UserSession,

  /// <summary>
  /// A user grant.
  /// </summary>
  UserGrants,

  /// <summary>
  /// A trust store.
  /// </summary>
  TrustStore,

  /// <summary>
  /// An API resource.
  /// </summary>
  ApiResource,

  /// <summary>
  /// An API resource secret.
  /// </summary>
  ApiResourceSecret,

  /// <summary>
  /// A claim.
  /// </summary>
  ClaimResource,

  /// <summary>
  /// A scope.
  /// </summary>
  Scope,

  /// <summary>
  /// An API scope.
  /// </summary>
  ApiScope,

  /// <summary>
  /// A cryptographic key material.
  /// </summary>
  KeyMaterial,

  /// <summary>
  /// The system.
  /// </summary>
  System
}


