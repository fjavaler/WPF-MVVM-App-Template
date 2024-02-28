using WPFAppTemplate.Navigation.Abstract;

namespace WPFAppTemplate.Navigation.Concrete
{
  /// <summary>
  /// Navigation service.
  /// </summary>
  public class NavigationService : INavigationService
  {
    #region Properties
    /// <inheritdoc/>
    public IServiceProvider ServiceProvider { get; set; }
    #endregion

    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="NavigationService"/> class.
    /// </summary>
    /// <param name="serviceProvider">Service provider.</param>
    public NavigationService(IServiceProvider serviceProvider)
    {
      ServiceProvider = serviceProvider;
    }
    #endregion

    #region Methods
    /// <inheritdoc/>
    public void Navigate<T>()
    {
      var page = ServiceProvider.GetService(typeof(T));
      var mainFrame = System.Windows.Application.Current.MainWindow.FindName("MainFrame") as System.Windows.Controls.Frame;
      mainFrame?.Navigate(page);
    }
    #endregion
  }
}
