namespace MonoCloud.Management.Models;

/// <summary>
/// The pagination header.
/// </summary>
public class PaginationHeader
{
  /// <summary>
  /// Number of items returned per page.
  /// </summary>
  public int PageSize { get; set; }

  /// <summary>
  /// The current page number.
  /// </summary>
  public int CurrentPage { get; set; }

  /// <summary>
  /// Total number of items available.
  /// </summary>
  public int TotalCount { get; set; }

  /// <summary>
  /// Indicates whether a previous page exists.
  /// </summary>
  public bool HasPrevious { get; set; }

  /// <summary>
  /// Indicates whether a next page exists.
  /// </summary>
  public bool HasNext { get; set; }
}


