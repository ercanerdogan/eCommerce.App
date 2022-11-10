using ECommerceApp.Application.Abstractions;
using ECommerceApp.Persistence.Concretes;
using ECommerceApp.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ECommerceAPIDbContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionInfo("PostgreSQL"));
            });
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
