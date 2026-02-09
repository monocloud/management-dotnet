namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Group Request: Used to update one or more properties of an existing group.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchGroupRequest>))]
public class PatchGroupRequest
{
  /// <summary>
  /// The display name of the group.
  /// </summary>
  public Optional<string> Name { get; set; }

  /// <summary>
  /// Description that explains the purpose or role of the group.
  /// </summary>
  public Optional<string?> Description { get; set; }

  /// <summary>
  /// Indicates whether users are automatically added to this group upon sign-up.
  /// </summary>
  public Optional<bool> IsAutoAssigned { get; set; }
}


