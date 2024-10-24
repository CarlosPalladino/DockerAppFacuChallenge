using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures.Configuration
{
    public static class ConfigurationExtension
    {
        public static void AddDbContext(this IServiceCollection configuration)
        {


            IConfiguration _config;

            using (var ServiceScope = configuration.BuildServiceProvider().CreateScope())
            {
                _config = ServiceScope.ServiceProvider.GetService<IConfiguration>()!;
            }

            var ApllicationOptions = new ApplicationOptions();

            var connectionString = ApllicationOptions.ConnectionString;

            _config.GetSection(ApllicationOptions.ConnectionString).Bind(ApllicationOptions);
            configuration.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

        }

    }
}
