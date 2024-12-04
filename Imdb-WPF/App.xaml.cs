﻿using Imdb_Libary;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Imdb_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider Services { get; }

        public App()
        {
            Services = ConfigureServices();
            this.InitializeComponent();
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IAppServices, AppServices>();
            services.AddDbContext<FilmContext>();
            return services.BuildServiceProvider();
        }
        public new static App Current => (App)Application.Current;
    }

}
