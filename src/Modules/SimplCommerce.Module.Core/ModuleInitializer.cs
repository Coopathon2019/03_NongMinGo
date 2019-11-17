﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SimplCommerce.Infrastructure;
using SimplCommerce.Infrastructure.Modules;
using SimplCommerce.Module.Core.Extensions;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Core.Services;

namespace SimplCommerce.Module.Core
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IEntityService, EntityService>();
            serviceCollection.AddTransient<IMediaService, MediaService>();
            serviceCollection.AddTransient<IThemeService, ThemeService>();
            serviceCollection.AddTransient<IConnectionService, ConnectionService>();

            // CodeNote : WidgetInstanceService 是 WidgetInstance 的上層乘載，負責管理與統包 WidgetInstance
            serviceCollection.AddTransient<IWidgetInstanceService, WidgetInstanceService>();

            serviceCollection.AddScoped<SignInManager<User>, SimplSignInManager<User>>();
            serviceCollection.AddScoped<IWorkContext, WorkContext>();
            serviceCollection.AddScoped<ISmsSender, SmsSender>();
            serviceCollection.AddSingleton<SettingDefinitionProvider>();
            serviceCollection.AddScoped<ISettingService, SettingService>();
            serviceCollection.AddScoped<ICurrencyService, CurrencyService>();

            GlobalConfiguration.RegisterAngularModule("simplAdmin.core");
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
        }
    }
}