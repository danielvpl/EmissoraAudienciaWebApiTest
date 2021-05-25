using Data.Repositories;
using Domain.Interfaces;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class DependencyInjection
    {
        public static void AddConfigurations(IServiceCollection services)
        {

            //Repositories
            services.AddTransient<IEmissoraRepository, EmissoraRepository>();
            services.AddTransient<IAudienciaRepository, AudienciaRepository>();
            //Services
            services.AddTransient<IEmissoraService, EmissoraService>();
            services.AddTransient<IAudienciaService, AudienciaService>();            
        }
    }
}
