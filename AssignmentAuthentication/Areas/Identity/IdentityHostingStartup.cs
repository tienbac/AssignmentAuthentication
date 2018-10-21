using System;
using AssignmentAuthentication.Areas.Identity.Data;
using AssignmentAuthentication.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AssignmentAuthentication.Areas.Identity.IdentityHostingStartup))]
namespace AssignmentAuthentication.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AssignmentAuthenticationContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AssignmentAuthenticationContextConnection")));

                services.AddDefaultIdentity<AssignmentAuthenticationUser>()
                    .AddEntityFrameworkStores<AssignmentAuthenticationContext>();
            });
        }
    }
}