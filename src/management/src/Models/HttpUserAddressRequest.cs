namespace MonoCloud.Management.Models;


[JsonConverter(typeof(PatchConverter<HttpUserAddressRequest>))]
public class HttpUserAddressRequest
{
  /// <summary>
  /// Single string combining various components of the address, such as street address, locality, region, postal code, and country.
  /// </summary>
  public Optional<string?> Formatted { get; set; }

  /// <summary>
  /// The street part of the address, typically including house/building number and street name.
  /// </summary>
  public Optional<string?> StreetAddress { get; set; }

  /// <summary>
  /// The city or town of the address.
  /// </summary>
  public Optional<string?> Locality { get; set; }

  /// <summary>
  /// The state, province, or administrative region associated with the address.
  /// </summary>
  public Optional<string?> Region { get; set; }

  /// <summary>
  /// Postal code of the address.
  /// </summary>
  public Optional<string?> PostalCode { get; set; }

  /// <summary>
  /// The name of the country associated with the address.
  /// </summary>
  public Optional<string?> Country { get; set; }
}


