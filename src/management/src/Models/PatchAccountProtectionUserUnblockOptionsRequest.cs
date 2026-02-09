namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Account Protection User Unblock Options Request: Used to update user account unblock configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAccountProtectionUserUnblockOptionsRequest>))]
public class PatchAccountProtectionUserUnblockOptionsRequest
{
  /// <summary>
  /// Email-based user unblock configuration.
  /// </summary>
  public Optional<PatchAccountProtectionUserUnblockEmailOptionsRequest> Email { get; set; }
}


