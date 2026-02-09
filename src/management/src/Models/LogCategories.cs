namespace MonoCloud.Management.Models;

/// <summary>
/// The log event category.
/// </summary>
public enum LogCategories
{
  /// <summary>
  /// Events related to user authentication and sign-in flows.
  /// </summary>
  Authentication,

  /// <summary>
  /// Events related to token issuance, refresh, and validation.
  /// </summary>
  Tokens,

  /// <summary>
  /// Events related to user consent and permission approval.
  /// </summary>
  Consent,

  /// <summary>
  /// Events related to security blocks and enforcement actions.
  /// </summary>
  Blocks,

  /// <summary>
  /// Events related to user lifecycle and profile changes.
  /// </summary>
  Users,

  /// <summary>
  /// Events related to user session creation, termination, and activity.
  /// </summary>
  UserSessions,

  /// <summary>
  /// Events related to notifications and message delivery.
  /// </summary>
  Notifications,

  /// <summary>
  /// Events related to identity resources, API resources, and protected backend services.
  /// </summary>
  Resources,

  /// <summary>
  /// Events related to mTLS trust stores and certificate validation.
  /// </summary>
  TrustStore,

  /// <summary>
  /// Events related to OAuth and OIDC client configuration.
  /// </summary>
  Clients,

  /// <summary>
  /// Events related to group management and membership changes.
  /// </summary>
  Groups
}


