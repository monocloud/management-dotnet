namespace MonoCloud.Management.Models;

/// <summary>
/// Unblock IP Request: Used to remove an IP-based lockout for a user.
/// </summary>
public class UnblockIpRequest
{
  /// <summary>
  /// The IP address to unblock. Use &#x60;all&#x60; to reset blocks for all IP addresses associated with the user.
  /// </summary>
  public string IpAddress { get; set; }
}


