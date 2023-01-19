using Pshop.Domain.Common;

namespace Pshop.Domain.Entities;

public class ProductType : BaseEntity
{
    [Required]
    [StringLength(128)]
    public string Title { get; set; }

    public ICollection<Product> Products { get; set; }
}
