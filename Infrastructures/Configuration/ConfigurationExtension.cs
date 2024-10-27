using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures.Configuration
{
    public static class ConfigurationExtension
    {
        public static void AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var applicationOptions = new ApplicationOptions();
            configuration.GetSection(ApplicationOptions.section).Bind(applicationOptions);

            string connectionString = applicationOptions.ConnectionString;
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
        }
    }


}
