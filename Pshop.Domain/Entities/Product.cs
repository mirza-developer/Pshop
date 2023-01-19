using Pshop.Domain.Common;

namespace Pshop.Domain.Entities;

public class Product : BaseEntity
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; }

    [Required]
    [StringLength(32)]
    public string Serial { get; set; }

    [Required]
    [StringLength(32)]
    public string Brand { get; set; }

    [StringLength(32)]
    public string? ProductCountry { get; set; }

    [Required]
    public bool IsActive { get; set; }

    [StringLength(256)]
    public string? Description { get; set; }

    public ICollection<ProductColor> Colors { get; set; }

    public Guid ProductTypeId { get; set; }
    public ProductType ProductType { get; set; }
}
