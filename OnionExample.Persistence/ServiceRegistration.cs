using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionExample.Application.Interfaces.Repositories;
using OnionExample.Application.Interfaces.UnitOfWork;
using OnionExample.Persistence.Context;
using OnionExample.Persistence.Repositories;
using OnionExample.Persistence.UnitOfWorks;

namespace OnionExample.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));

            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
            serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();
        }

    }
}
