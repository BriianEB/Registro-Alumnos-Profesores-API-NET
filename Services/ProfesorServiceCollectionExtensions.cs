using Microsoft.Extensions.DependencyInjection;

namespace RegistroAlumnosYProfesoresAPI.Services
{
    public static class ProfesorServiceCollectionExtensions
    {
        public static IServiceCollection AddProfesorService(this IServiceCollection services)
        {
            services.AddScoped<ProfesorService>();

            return services;
        }
    }
}