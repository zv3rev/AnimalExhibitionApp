using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using AnimalExhibition.Settings;

namespace AnimalExhibition.Context
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddAppDbContext(this IServiceCollection services, IConfiguration configuration = null) 
        {
            DbSettings settings = Settings.Settings.Load<DbSettings>("Database", configuration);
            services.AddSingleton(settings);

            var dbInitOptionsDelegate = DbContextOptionsFactory.Configure(settings.ConnectionString, settings.Type);
            services.AddDbContextFactory<MainDbContext>(dbInitOptionsDelegate);

            //services.AddDbContextFactory<MainDbContext>(dbInitOptionsDelegate);
            return services;
            
        }
    }
}
