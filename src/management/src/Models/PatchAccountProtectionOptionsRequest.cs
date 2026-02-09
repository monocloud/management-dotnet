namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Account Protection Options Request: Used to update user account protection settings.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAccountProtectionOptionsRequest>))]
public class PatchAccountProtectionOptionsRequest
{
  /// <summary>
  /// User account protection settings used to safeguard accounts from abuse.
  /// </summary>
  public Optional<PatchAccountProtectionUserLockoutOptionsRequest> UserLockout { get; set; }
}


