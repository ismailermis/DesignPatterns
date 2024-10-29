using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OptionPattern.Api.GitHub;

namespace OptionPattern.Api
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddOptionsValidationWithFluentValidation<TOptions>(
            this IServiceCollection services, string configurationSection)
            where TOptions : class
        {
            services.AddOptions<TOptions>()
            .BindConfiguration(configurationSection)
            .ValidateFluentValidation()
            .ValidateOnStart();
            return services;
        }

    }
}