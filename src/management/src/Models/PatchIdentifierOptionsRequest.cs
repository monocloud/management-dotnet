namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Identifier Options Request: Used to update email, phone, and username identifier configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchIdentifierOptionsRequest>))]
public class PatchIdentifierOptionsRequest
{
  /// <summary>
  /// Email Identifier Options
  /// </summary>
  public Optional<PatchEmailIdentifierOptionsRequest> Email { get; set; }

  /// <summary>
  /// Phone Identifier Options
  /// </summary>
  public Optional<PatchPhoneIdentifierOptionsRequest> Phone { get; set; }

  /// <summary>
  /// Username Identifier Options
  /// </summary>
  public Optional<PatchUsernameIdentifierOptionsRequest> Username { get; set; }
}


