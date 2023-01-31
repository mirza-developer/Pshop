using Pshop.Domain.Common;
using System.Reflection.Metadata;

namespace Pshop.Domain.Entities;

public class DiscountCode : BaseEntity
{
    [Required]
    [StringLength(20)]
    public string Code { get; set; }
    public int Percent { get; set; }
    public DateTime ExpireDate { get; set; }
    public bool IsExpired { get; set; }
    public int? UseCountLimit { get; set; }

    public ICollection<Invoice> Invoices { get; set;}
}
