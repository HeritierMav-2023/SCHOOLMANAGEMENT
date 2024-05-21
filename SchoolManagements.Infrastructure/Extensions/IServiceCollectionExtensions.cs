using Microsoft.Extensions.DependencyInjection;
using SchoolManagements.Domain.Common.Interfaces;
using SchoolManagements.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolManagements.Infrastructure.Persistences;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Infrastructure.Repositories;


namespace SchoolManagements.Infrastructure.Extensions
{
    /// <summary>
    /// Classe d'extensions
    /// </summary>
    public static class IServiceCollectionExtensions
    {
        public static void AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext(configuration);
            services.AddServices();
            services.AddRepositories();
        }

        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<SchoolManagementDbContext>(options =>
               options.UseSqlServer(connectionString,
                   builder => builder.MigrationsAssembly(typeof(SchoolManagementDbContext).Assembly.FullName)));
        }

        private static void AddServices(this IServiceCollection services)
        {
            services
                .AddTransient<IDomainEventDispatcher, DomainEventDispatcher>();
            
        }

        private static void AddRepositories(this IServiceCollection services)
        {
            services
                .AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork))
                .AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>))
                .AddTransient<IStandardRepository, StandardRepository>()
                .AddTransient<IStudentRepository, StudentRepository>();
        }

    }
}
