using Estudo.Dominio.Services;
using Estudo.Dominio.Services.Interfaces;
using Estudo.Infra.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Extensions
{
    public static class IServiceCollectionExtension
    {
        public static void RegisterDomainServices(this IServiceCollection services)
        {
            services.AddSingleton<IClienteService, ClienteService>();
            services.AddSingleton<IReceitaFederalService, ReceitaFederalService>();
        }
    }
}
