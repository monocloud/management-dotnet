namespace MonoCloud.Management.Models;

/// <summary>
/// The log event actor type.
/// </summary>
public enum ActorTypes
{
  /// <summary>
  /// The actor could not be determined.
  /// </summary>
  Unknown,

  /// <summary>
  /// The platform or internal system.
  /// </summary>
  System,

  /// <summary>
  /// An API key.
  /// </summary>
  ApiKey,

  /// <summary>
  /// A private API key.
  /// </summary>
  PrivateApiKey,

  /// <summary>
  /// A public API key.
  /// </summary>
  PublicApiKey,

  /// <summary>
  /// An end user.
  /// </summary>
  User,

  /// <summary>
  /// An administrative user.
  /// </summary>
  AdminUser,

  /// <summary>
  /// An API or protected service.
  /// </summary>
  Api,

  /// <summary>
  /// A client application.
  /// </summary>
  Client,

  /// <summary>
  /// An X.509 certificate.
  /// </summary>
  Certificate
}


