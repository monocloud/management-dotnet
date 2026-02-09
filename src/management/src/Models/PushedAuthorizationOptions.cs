namespace MonoCloud.Management.Models;

/// <summary>
/// Pushed Authorization Options Response: Represents the tenant-wide Pushed Authorization Request (PAR) configuration.
/// </summary>
public class PushedAuthorizationOptions
{
  /// <summary>
  /// Specifies whether Pushed Authorization Requests (PAR) are enabled for the tenant.
  /// </summary>
  public bool EnablePushedAuthorizationRequests { get; set; }

  /// <summary>
  /// Specifies whether Pushed Authorization Requests (PAR) are required tenant-wide for all authorization requests.
  /// </summary>
  /// <note>When enabled, this setting overrides any client-specific PAR configuration and enforces PAR usage for all clients within the tenant.</note>
  public bool RequirePushedAuthorizationRequests { get; set; }
}


