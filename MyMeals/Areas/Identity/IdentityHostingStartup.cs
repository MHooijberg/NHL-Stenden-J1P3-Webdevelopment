using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyMeals.Areas.Identity.Data;
using MyMeals.Data;
using MyMeals.Models;

[assembly: HostingStartup(typeof(MyMeals.Areas.Identity.IdentityHostingStartup))]
namespace MyMeals.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MijnMaaltijdContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MijnMaaltijdContext")));
                        //context.Configuration.GetConnectionString("MyMealsContextConnection")));

                services.AddDefaultIdentity<Gebruiker>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MijnMaaltijdContext>();
            });
        }
    }
}