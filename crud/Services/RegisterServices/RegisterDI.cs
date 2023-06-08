using crud.Models;
using crud.Services.Mapping;

namespace crud.Services.RegisterServices
{
    public static class RegisterDI
    {
        public static void RegisterDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<Composite>();
            services.AddScoped<BlogMapper>();
        }
    }
}
