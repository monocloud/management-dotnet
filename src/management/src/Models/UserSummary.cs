namespace MonoCloud.Management.Models;

/// <summary>
/// User Summary: A lightweight user representation returned in list operations.
/// </summary>
public class UserSummary
{
  /// <summary>
  /// The unique identifier of the user.
  /// </summary>
  public string UserId { get; set; }

  /// <summary>
  /// Indicates whether the account has been disabled.
  /// </summary>
  public bool Disabled { get; set; }

  /// <summary>
  /// Connections linked to this user.
  /// </summary>
  public List<UserConnection> Connections { get; set; }

  /// <summary>
  /// Claims associated with the user.
  /// </summary>
  public Dictionary<string, object> Claims { get; set; }

  /// <summary>
  /// List of registered emails of the user.
  /// </summary>
  public List<UserEmail> Emails { get; set; }

  /// <summary>
  /// List of registered phones of the user.
  /// </summary>
  public List<UserPhone> PhoneNumbers { get; set; }

  /// <summary>
  /// List of registered passkeys of the user.
  /// </summary>
  public List<UserPasskey> Passkeys { get; set; }

  /// <summary>
  /// A flag indicating whether the user must change their password on next sign-in.
  /// </summary>
  public bool ForcePasswordReset { get; set; }

  /// <summary>
  /// External provider profiles linked to this user.
  /// </summary>
  public List<UserExternalProviderSummary> ExternalProviders { get; set; }

  /// <summary>
  /// Specifies the creation time of the user (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the user (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }

  /// <summary>
  /// Registered username for the user.
  /// </summary>
  public UserUsername? Username { get; set; }

  /// <summary>
  /// Indicates whether the user has a password set.
  /// </summary>
  public bool HasPassword { get; set; }

  /// <summary>
  /// Specifies the time of the last password update (in Epoch).
  /// </summary>
  public DateTime? PasswordUpdatedAt { get; set; }

  /// <summary>
  /// Specifies the time at which the user will be unblocked (in Epoch).
  /// </summary>
  public long? BlockUntil { get; set; }

  /// <summary>
  /// Consecutive sign-in failures since the last successful sign-in.
  /// </summary>
  public int FailureCount { get; set; }

  /// <summary>
  /// Total sign-in attempts recorded for the user.
  /// </summary>
  public int SignInAttemptsCount { get; set; }

  /// <summary>
  /// Specifies the time of the last sign-in attempt (in Epoch).
  /// </summary>
  public DateTime? LastSignInAttempt { get; set; }

  /// <summary>
  /// IP address of the last sign-in attempt.
  /// </summary>
  public string? LastSignInAttemptIp { get; set; }

  /// <summary>
  /// Total successful sign-ins recorded for the user.
  /// </summary>
  public int SignInSuccessCount { get; set; }

  /// <summary>
  /// Specifies the time of the last successful sign-in (in Epoch).
  /// </summary>
  public DateTime? LastSignInSuccess { get; set; }

  /// <summary>
  /// IP address of the last successful sign-in.
  /// </summary>
  public string? LastSignInSuccessIp { get; set; }

  /// <summary>
  /// Specifies the time of the last recorded user activity (in Epoch).
  /// </summary>
  public DateTime? LastActivity { get; set; }

  /// <summary>
  /// Last recorded city for the user.
  /// </summary>
  public string? LastKnownCity { get; set; }

  /// <summary>
  /// Last recorded country for the user.
  /// </summary>
  public string? LastKnownCountry { get; set; }

  /// <summary>
  /// Last recorded region for the user.
  /// </summary>
  public string? LastKnownRegion { get; set; }
}


