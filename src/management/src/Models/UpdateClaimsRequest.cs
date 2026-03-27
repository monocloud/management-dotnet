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

  /// <summary>
  /// Preferred username for the user which may be display purposes.
  /// </summary>
  public Optional<string?> PreferredUsername { get; set; }

  /// <summary>
  /// URL of the user&#39;s profile page.
  /// </summary>
  public Optional<string?> Profile { get; set; }

  /// <summary>
  /// User&#39;s birth date in ISO 8601 format (YYYY-MM-DD).
  /// </summary>
  public Optional<string?> Birthdate { get; set; }

  /// <summary>
  /// URL of the user&#39;s personal or professional website.
  /// </summary>
  public Optional<string?> Website { get; set; }

  /// <summary>
  /// User&#39;s gender.
  /// </summary>
  public Optional<string?> Gender { get; set; }

  /// <summary>
  /// Time zone associated with the user&#39;s location expressed using a IANA time zone name.
  /// </summary>
  public Optional<string?> Zoneinfo { get; set; }

  /// <summary>
  /// Preferred locale of the user expressed using a BCP 47 language tag.
  /// </summary>
  public Optional<string?> Locale { get; set; }

  /// <summary>
  /// Physical or residential address associated with the user.
  /// </summary>
  public Optional<HttpUserAddressRequest?> Address { get; set; }

  /// <summary>
  /// Allows bypassing profile conformance checks enforced by sign-up policies.
  /// </summary>
  public Optional<bool> SkipConformanceChecks { get; set; }
}


