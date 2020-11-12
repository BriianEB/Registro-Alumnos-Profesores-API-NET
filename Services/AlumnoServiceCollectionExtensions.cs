using Microsoft.Extensions.DependencyInjection;

namespace RegistroAlumnosYProfesoresAPI.Services
{
    public static class AlumnoServiceCollectionExtensions {
        public static IServiceCollection AddAlumnoService(this IServiceCollection services)
        {
            services.AddScoped<AlumnoService>();
            
            return services;
        }
    }
}