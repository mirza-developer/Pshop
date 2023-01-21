using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Pshop.Identity.Models;

public class PshopUser : IdentityUser
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(128)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(128)]
    public string LastName { get; set; }
    public DateTime CreateDatetime { get; set; }
    public Guid CreatorId { get; set; }
    public DateTime? LastModifierDatetime { get; set; }
    public Guid? LastModifierId { get; set; }

    public ICollection<UserAddress> Addresses { get; set; }
}
