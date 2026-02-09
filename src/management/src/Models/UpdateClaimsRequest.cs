namespace MonoCloud.Management.Models;

/// <summary>
/// Update Claims Request: Updates standard profile claims associated with a user account.
/// </summary>
[JsonConverter(typeof(PatchConverter<UpdateClaimsRequest>))]
public class UpdateClaimsRequest
{
  /// <summary>
  /// Full name of the user.
  /// </summary>
  public Optional<string?> Name { get; set; }

  /// <summary>
  /// Given (first) name of the user.
  /// </summary>
  public Optional<string?> GivenName { get; set; }

  /// <summary>
  /// Middle name or initial of the user.
  /// </summary>
  public Optional<string?> MiddleName { get; set; }

  /// <summary>
  /// Family (last) name of the user.
  /// </summary>
  public Optional<string?> FamilyName { get; set; }

  /// <summary>
  /// Preferred nickname for the user.
  /// </summary>
  public Optional<string?> Nickname { get; set; }

  /// <summary>
  /// URL of the user&#39;s profile image.
  /// </summary>
  public Optional<string?> Picture { get; set; }
}


