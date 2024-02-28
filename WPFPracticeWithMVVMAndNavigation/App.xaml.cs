using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using WPFAppTemplate.Service;
using WPFAppTemplate.View;
using WPFAppTemplate.ViewModel;
using WPFAppTemplate.Navigation;

namespace WPFAppTemplate
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    private IHost? _host;

    protected override async void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);

      try
      {
        _host = CreateHostBuilder().Build();
        await _host.StartAsync();

        var mainWindow = _host.Services.GetRequiredService<MainWindow>();
        mainWindow.Show();
      }
      catch (Exception ex)
      {
        MessageBox.Show($"An error occurred during application startup: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        Shutdown();
      }
    }

    protected override async void OnExit(ExitEventArgs e)
    {
      base.OnExit(e);

      using (_host)
      {
        await _host!.StopAsync();
      }
    }

    private static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
              services.AddSingleton<IDataService, DataService>();
              services.AddScoped<INavigationService>(serviceProvider =>
              {
                var navigationService = new NavigationService(serviceProvider);
                return navigationService;
              });

              services.AddTransient<MainWindow>();
              services.AddTransient<ExamplePage>();
              services.AddSingleton<ExampleViewModel>();
              services.AddTransient<AnotherExamplePage>();
              services.AddSingleton<AnotherExampleViewModel>();
            });
  }
}
