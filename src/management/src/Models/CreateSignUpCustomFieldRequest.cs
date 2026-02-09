namespace MonoCloud.Management.Models;

/// <summary>
/// Create Sign-Up Custom Field Request: Creates a configuration for a custom field collected during user sign-up.
/// </summary>
public class CreateSignUpCustomFieldRequest
{
  /// <summary>
  /// Specifies whether this custom field is enabled and shown during sign-up.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Specifies whether this custom field is mandatory during sign-up.
  /// </summary>
  public bool? Required { get; set; }

  /// <summary>
  /// The claim name under which the value will be stored.
  /// </summary>
  public string ClaimName { get; set; }

  /// <summary>
  /// The data type of the claim value.
  /// </summary>
  public ValueTypes? ValueType { get; set; }

  /// <summary>
  /// The user-facing label displayed for this field during sign-up.
  /// </summary>
  public string Label { get; set; }
}


