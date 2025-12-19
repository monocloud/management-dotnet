namespace MonoCloud.Management.Identity.Models;

/// <summary>
/// The Unblock IP Request class.
/// </summary>
public class UnblockIpRequest
{
  /// <summary>
  /// The IP address to unblock. Use &#x60;all&#x60; to reset lockouts for every IP currently associated with the user.
  /// </summary>
  public string IpAddress { get; set; }
}


