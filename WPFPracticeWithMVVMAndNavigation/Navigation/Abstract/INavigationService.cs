namespace WPFAppTemplate.Navigation.Abstract
{
  /// <summary>
  /// Interface for the navigation service.
  /// </summary>
  public interface INavigationService
  {
    #region Properties
    /// <summary>
    /// Gets or sets the service provider.
    /// </summary>
    IServiceProvider ServiceProvider { get; set; }
    #endregion

    #region Methods
    /// <summary>
    /// Navigates to the specified page.
    /// </summary>
    /// <typeparam name="T">Type.</typeparam>
    void Navigate<T>();
    #endregion
  }
}