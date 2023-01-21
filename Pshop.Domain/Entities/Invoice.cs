using Pshop.Domain.Common;

namespace Pshop.Domain.Entities;

public class Invoice : BaseEntity
{
    public Guid CartId { get; set; }
    public Cart Cart { get; set; }

    [Required]
    public InvoiceStatus InvoiceStatus { get; set; }
    public string? MerchantCode { get; set; }
    public long TotalPrice { get; set; }

    [Required]
    public PaymentPortal PaymentPortal { get; set; }
}

public enum InvoiceStatus
{
    NotPaid,
    Paid,
    Expired,
    Canceled,
    PaymentError
}

public enum PaymentPortal
{
    ZarrinPal
}