namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Account Protection User Unblock Email Options Request: Used to update email-based user unblock configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAccountProtectionUserUnblockEmailOptionsRequest>))]
public class PatchAccountProtectionUserUnblockEmailOptionsRequest
{
  /// <summary>
  /// Specifies the validity period of the unblock email link (in seconds).
  /// </summary>
  public Optional<int> Expiry { get; set; }
}


