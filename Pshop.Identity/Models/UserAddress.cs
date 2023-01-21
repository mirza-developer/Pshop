using System.ComponentModel.DataAnnotations;

namespace Pshop.Identity.Models;

public class UserAddress
{
    [Key]
    public Guid Id { get; set; }

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

    [Required]
    public Guid UserId { get; set; }
    public PshopUser User { get; set; }
}
