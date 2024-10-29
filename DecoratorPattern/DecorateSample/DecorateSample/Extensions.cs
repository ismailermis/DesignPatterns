using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecorateSample
{
    public static class Extensions
    {
        public static IServiceCollection AddDecoratedSingelton<TService,TDec,TFinal>(
            this IServiceCollection services,object key) 
            where TService : class
            where TFinal :class,TService
            where TDec : class,TService
        {
            services.AddKeyedSingleton<TService,TFinal>(key);
            services.AddSingleton<TService,TDec>();
            return services;

        }
    }
}