using crud.Repository;
using Microsoft.EntityFrameworkCore;

namespace crud.Services.RegisterServices
{
    public static class DbRegister
    {
        public static void RegisterDatabase(this IServiceCollection services,
                                            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(
                opts => opts.UseNpgsql(
                    configuration.GetConnectionString("postgres")),
                    ServiceLifetime.Scoped);
        }
    }
}
