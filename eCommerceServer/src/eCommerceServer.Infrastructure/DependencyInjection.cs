using eCommerceServer.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using GenericRepository;
using System.Reflection;
using Scrutor;

namespace eCommerceServer.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, 
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("SqlServer"));
        });

        //services.AddIdentity<AppUser, IdentityRole<Guid>>(options =>
        //{
        //    options.Password.RequireNonAlphanumeric = false;
        //    options.Password.RequireDigit = false;
        //    options.Password.RequiredLength = 1;
        //    options.Password.RequireUppercase = false;
        //    options.Password.RequireLowercase = false;
        //}).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

        services.AddScoped<IUnitOfWork>(srv => srv.GetRequiredService<ApplicationDbContext>());

        services.Scan(action =>
        {
            action
            .FromAssemblies(Assembly.GetExecutingAssembly())
            .AddClasses(publicOnly: false)
            .UsingRegistrationStrategy(RegistrationStrategy.Skip)
            .AsMatchingInterface()
            .AsImplementedInterfaces()
            .WithScopedLifetime();
        });

        return services;
    }
}
