namespace MonoCloud.Management.Identity.Models;

/// <summary>
/// The Patch Group class.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchGroupRequest>))]
public class PatchGroupRequest
{
  /// <summary>
  /// The display name of the group.
  /// </summary>
  public Optional<string> Name { get; set; }

  /// <summary>
  /// Optional description that indicates the purpose or role of the group.
  /// </summary>
  public Optional<string?> Description { get; set; }

  /// <summary>
  /// Indicates whether new users are automatically assigned to this group upon sign-up.
  /// </summary>
  public Optional<bool> IsAutoAssigned { get; set; }
}


