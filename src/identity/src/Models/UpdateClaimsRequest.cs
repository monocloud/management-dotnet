namespace MonoCloud.Management.Identity.Models;

/// <summary>
/// The Update Claims Request.
/// </summary>
[JsonConverter(typeof(PatchConverter<UpdateClaimsRequest>))]
public class UpdateClaimsRequest
{
  /// <summary>
  /// Full name of the user.
  /// </summary>
  public Optional<string?> Name { get; set; }

  /// <summary>
  /// The user&#39;s given (first) name.
  /// </summary>
  public Optional<string?> GivenName { get; set; }

  /// <summary>
  /// The user&#39;s middle name or initial, if applicable.
  /// </summary>
  public Optional<string?> MiddleName { get; set; }

  /// <summary>
  /// The user&#39;s family (last) name.
  /// </summary>
  public Optional<string?> FamilyName { get; set; }

  /// <summary>
  /// The user&#39;s preferred nickname.
  /// </summary>
  public Optional<string?> Nickname { get; set; }

  /// <summary>
  /// URL of the user’s profile image
  /// </summary>
  public Optional<string?> Picture { get; set; }
}


