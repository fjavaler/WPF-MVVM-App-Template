using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using WPFAppTemplate.View;
using WPFAppTemplate.ViewModel;
using WPFAppTemplate.Navigation.Abstract;
using WPFAppTemplate.Service.Concrete;
using WPFAppTemplate.Service.Abstract;
using WPFAppTemplate.Navigation.Concrete;

namespace WPFAppTemplate
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    #region Private Members
    /// <summary>
    /// The main host for the application.
    /// </summary>
    private IHost? _host;
    #endregion

    #region Methods
    /// <summary>
    /// Override of the OnStartup method to start the application.
    /// </summary>
    /// <param name="e">Startup event arguments.</param>
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

    /// <summary>
    /// Override of the OnExit method to stop the application.
    /// </summary>
    /// <param name="e">Exit event arguments.</param>
    protected override async void OnExit(ExitEventArgs e)
    {
      base.OnExit(e);

      using (_host)
      {
        await _host!.StopAsync();
      }
    }

    /// <summary>
    /// Creates the host builder for the application.
    /// </summary>
    /// <returns>A Host builder.</returns>
    private static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
              services.AddSingleton<IDataService, DataService>();
              services.AddScoped<INavigationService>(serviceProvider =>
              {
                var navigationService = new NavigationService(serviceProvider);
                return navigationService;
              });
              services.AddTransient<ILoggingService, LoggingService>();
              services.AddTransient<ISoundService, SoundService>();

              services.AddTransient<MainWindow>();
              services.AddTransient<ExamplePage>();
              services.AddSingleton<ExampleViewModel>();
              services.AddTransient<AnotherExamplePage>();
              services.AddSingleton<AnotherExampleViewModel>();
            });
    #endregion
  }
}