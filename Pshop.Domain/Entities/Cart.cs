using Pshop.Domain.Common;

namespace Pshop.Domain.Entities;

public class Cart : BaseEntity
{
    public Guid UserId { get; set; }

    public ICollection<CartItem> CartItems { get; set; }
    public ICollection<Invoice> Invoices { get; set; }
}
