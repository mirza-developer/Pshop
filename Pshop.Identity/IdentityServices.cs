using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pshop.Identity.Models;

namespace Pshop.Identity;

public static class IdentityServices
{
    public static void AddIdentityServices(this IServiceCollection services
        , IConfiguration configuration)
    {
        services.AddDbContext<PshopIdentityContext>(options => options.UseSqlServer(configuration.GetConnectionString("PshopIdentityConnectionString")));

        services.AddIdentity<PshopUser, IdentityRole>()
            .AddEntityFrameworkStores<PshopIdentityContext>().AddDefaultTokenProviders();
    }
}
