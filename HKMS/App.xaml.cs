﻿using CommunityToolkit.Mvvm.DependencyInjection;
using HKMS.DBModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HKMS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Ioc.Default.ConfigureServices(
                new ServiceCollection()
                .AddSingleton<MSDBContext>()
                .BuildServiceProvider()
            );

            var context = Ioc.Default.GetService<MSDBContext>();
            if ( context != null )
            {
                context.Database.EnsureCreated();
            }
            
        }
    }
}
