using Pshop.Domain.Common;

namespace Pshop.Domain.Entities;

public class Cart : BaseEntity
{
    public ICollection<CartItem> CartItems { get; set; }
    public ICollection<Invoice> Invoices { get; set; }
   
    [Required]
    public CartStatus CartStatus { get; set; }

    [Required]
    public SendType SendType { get; set; }

    [Required]
    [StringLength(50)]
    public string Province { get; set; }

    [Required]
    [StringLength(50)]
    public string City { get; set; }

    [Required]
    [StringLength(512)]
    public string FullAddress { get; set; }

    [StringLength(20)]
    public string? PostalCode { get; set; }
}

public enum CartStatus
{
    NotPaid,
    Expired,
    Removed,
    Paid
}

public enum SendType
{
    Post,
    Tipax,
    Snapp
}