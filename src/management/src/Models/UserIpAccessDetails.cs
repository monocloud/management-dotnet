namespace MonoCloud.Management.Models;

/// <summary>
/// User IP Access Details: Returns sign-in activity for a specific IP address.
/// </summary>
public class UserIpAccessDetails
{
  /// <summary>
  /// Consecutive sign-in failures from this IP address since the last successful sign-in.
  /// </summary>
  public int FailureCount { get; set; }

  /// <summary>
  /// Specifies the time until which sign-in attempts from this IP address are blocked (in Epoch).
  /// </summary>
  public DateTime? BlockUntil { get; set; }

  /// <summary>
  /// Total number of sign-in attempts from this IP address.
  /// </summary>
  public int SignInAttemptsCount { get; set; }

  /// <summary>
  /// The IP address from which sign-in attempts were made.
  /// </summary>
  public string Ip { get; set; }

  /// <summary>
  /// Specifies the time of the most recent sign-in attempt from this IP address (in Epoch).
  /// </summary>
  public DateTime LastSignInAttempt { get; set; }
}


