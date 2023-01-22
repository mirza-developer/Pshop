using Pshop.Domain.Common;

namespace Pshop.Domain.Entities;

public class Discount : BaseEntity
{
    public int Percent { get; set; }
    public DateTime ExpireDate { get; set; }
    public bool IsExpired { get; set; }
    public int? UseCountLimit { get; set; }

    public ICollection<Invoice> Invoices { get; set;}
}
