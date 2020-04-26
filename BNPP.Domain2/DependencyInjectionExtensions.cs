using AutoMapper;
using BNPP.Domain.Interfaces.Repositories;
using BNPP.Domain.Interfaces.Services;
using BNPP.Domain.Repositories;
using BNPP.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BNPP.Domain
{
    public static class DependencyInjectionExtensions
    {
        /// <summary>
        /// Configure basic Dependencies Injection like Services and Repositories
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection ConfigureDomainDependencies(this IServiceCollection services)
        {
            //Services
            services.AddScoped<IManualMovementsService, ManualMovementsService>();


            //Repositories
            services.AddScoped<IManualMovementsRepository, ManualMovementsRepository>();


            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);



            return services;
        }

        public static IServiceCollection ConfigureProfilesDependencies(this IServiceCollection services, List<Profile> profiles = null)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                profiles.ForEach(p => mc.AddProfile(p));
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
