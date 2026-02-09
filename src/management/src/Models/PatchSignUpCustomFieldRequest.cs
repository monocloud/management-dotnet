namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Sign-Up Custom Field Request: Used to update a sign-up custom field configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchSignUpCustomFieldRequest>))]
public class PatchSignUpCustomFieldRequest
{
  /// <summary>
  /// Specifies whether this custom field is enabled and shown during sign-up.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Specifies whether this custom field is mandatory during sign-up.
  /// </summary>
  public Optional<bool> Required { get; set; }

  /// <summary>
  /// The claim name under which the value will be stored.
  /// </summary>
  public Optional<string> ClaimName { get; set; }

  /// <summary>
  /// The data type of the claim value.
  /// </summary>
  public Optional<ValueTypes> ValueType { get; set; }

  /// <summary>
  /// The user-facing label displayed for this field during sign-up.
  /// </summary>
  public Optional<string> Label { get; set; }
}


