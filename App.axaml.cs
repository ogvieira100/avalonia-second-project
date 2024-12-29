using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;

namespace customer;

public partial class App : Application
{

     public IServiceProvider? Services { get; private set; }

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is  IClassicDesktopStyleApplicationLifetime desktop)
        {
              // Configurar os serviços
            var services = new ServiceCollection();
            ConfigureServices(services);

            Services = services.BuildServiceProvider();
            desktop.MainWindow = new MainWindow();
        }

        base.OnFrameworkInitializationCompleted();
    }
    private void ConfigureServices(ServiceCollection services)
    {
            services.AddSingleton<IDatabaseFactory, MySqlFactory>();
            
    }
}