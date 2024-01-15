using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VirtualBookstore.Application.Repositories;
using VirtualBookstore.Infrastructure.Data.Context;
using VirtualBookstore.Infrastructure.Data.Repositories;
using VirtualBookstore.Infrastructure.ExternalServices.Services;
using Refit;

namespace VirtualBookstore.CrossCutting.IoC
{
    public static class ConfigurationIoC
    {
        public static void ConfigureIoC(this IServiceCollection services, IConfiguration configuration)
        {
            ConfigurePersistence(services, configuration);
            ConfigureRepositories(services);
            ConfigureExternalServices(services, configuration);
        }

        private static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("WebApiDatabase") ?? throw new Exception("Connection string não encontrada no arquivo de configuração");
            services.AddDbContext<VirtualBookstoreContext>(opt => opt.UseSqlServer(connectionString, b => b.MigrationsAssembly("VirtualBookstore.Infrastructure.Data")));
        }

        private static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
        }

        public static void ConfigureExternalServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRefitClient<IViaCEPExternalService>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri(configuration.GetSection("ExternalServices:ViaCEP:BaseAddress").Value ??
                throw new InvalidOperationException("Url base não encontrada no arquivo de configuração")));
        }
    }
}
