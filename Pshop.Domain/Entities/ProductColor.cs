using Pshop.Domain.Common;

namespace Pshop.Domain.Entities;

public class ProductColor : BaseEntity
{
    [Required]
    [StringLength(64)]
    public string Name { get; set; }

    [Required]
    [StringLength(10)]
    public string? HexCode { get; set; }

    [Required]
    public int Count { get; set; }

    [Required]
    public int ReservedCount { get; set; }

    [Required]
    public decimal Price { get; set; }

    public int? DiscountPercent { get; set; }

    public Guid ProductId { get; set; }
    public Product Product { get; set; }
}
