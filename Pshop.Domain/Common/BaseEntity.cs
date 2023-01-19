using System.ComponentModel.DataAnnotations;

namespace Pshop.Domain.Common;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
    public DateTime CreateDatetime { get; set; }
    public Guid CreatorId { get; set; }
    public DateTime? LastModifierDatetime { get; set; }
    public Guid? LastModifierId { get; set; }
}
