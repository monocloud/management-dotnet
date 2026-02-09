namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Pushed Authorization Options Request: Used to update tenant-wide Pushed Authorization Request (PAR) configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchPushedAuthorizationOptionsRequest>))]
public class PatchPushedAuthorizationOptionsRequest
{
  /// <summary>
  /// Specifies whether Pushed Authorization Requests (PAR) are enabled for the tenant.
  /// </summary>
  public Optional<bool> EnablePushedAuthorizationRequests { get; set; }

  /// <summary>
  /// Specifies whether Pushed Authorization Requests (PAR) are required tenant-wide for all authorization requests.
  /// </summary>
  /// <note>When enabled, this setting overrides any client-specific PAR configuration and enforces PAR usage for all clients within the tenant.</note>
  public Optional<bool> RequirePushedAuthorizationRequests { get; set; }
}


