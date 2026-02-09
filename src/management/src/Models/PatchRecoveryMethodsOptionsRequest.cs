namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Recovery Methods Options Request: Used to update account and password recovery configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchRecoveryMethodsOptionsRequest>))]
public class PatchRecoveryMethodsOptionsRequest
{
  /// <summary>
  /// Recovery Methods Email Options
  /// </summary>
  public Optional<PatchRecoveryMethodsEmailOptionsRequest> Email { get; set; }

  /// <summary>
  /// Recovery Methods Phone Options
  /// </summary>
  public Optional<PatchRecoveryMethodsPhoneOptionsRequest> Phone { get; set; }
}


