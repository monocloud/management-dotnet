namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Password Reuse Options Request: Used to partially update password reuse enforcement settings.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchPasswordReuseOptionsRequest>))]
public class PatchPasswordReuseOptionsRequest
{
  /// <summary>
  /// Specifies the password reuse control policy, defining whether reuse is limited by time, count, both, or unrestricted.
  /// </summary>
  /// <note>Pro plan required to configure password reuse options.</note>
  public Optional<PasswordRestrictionModes> RestrictionMode { get; set; }

  /// <summary>
  /// Specifies the time period during which previously used passwords are blocked from reuse (in minutes).
  /// </summary>
  public Optional<int> RestrictionPeriod { get; set; }

  /// <summary>
  /// Defines the number of historical passwords that are disallowed for reuse under count-based enforcement.
  /// </summary>
  public Optional<int> RestrictionCount { get; set; }
}


