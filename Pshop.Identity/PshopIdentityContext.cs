using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pshop.Identity.Models;

namespace Pshop.Identity;

public class PshopIdentityContext : IdentityDbContext<PshopUser>
{
    public PshopIdentityContext(DbContextOptions<PshopIdentityContext> options) : base(options)
    {
        Database.Migrate();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
