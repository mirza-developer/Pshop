using Pshop.Domain.Common;

namespace Pshop.Domain.Entities;

public class CartItem : BaseEntity
{
    public Guid CartId { get; set; }
    public Cart Cart { get; set; }

    public Guid ProductColorId { get; set; }
    public ProductColor ProductColor { get; set; }
}
