﻿using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Microsoft.AspNetCore.Http;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollection.AddSingleton<Stopwatch>();


        }
    }
}
