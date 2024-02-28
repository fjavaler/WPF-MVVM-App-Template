using System.Windows.Input;
using WPFAppTemplate.Commands;
using WPFAppTemplate.Navigation.Abstract;
using WPFAppTemplate.View;

namespace WPFAppTemplate.ViewModel
{
  /// <summary>
  /// View model for the AnotherExamplePage.
  /// </summary>
  public class AnotherExampleViewModel : ViewModelBase
  {
    #region Fields
    /// <summary>
    /// Navigation service.
    /// </summary>
    private readonly INavigationService navigationService;
    #endregion

    #region Properties
    /// <summary>
    /// Command to navigate to the main page.
    /// </summary>
    public ICommand GoToMainPageCommand { get; private set; }
    #endregion

    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="AnotherExampleViewModel"/> class.
    /// </summary>
    /// <param name="navigationService">The navigation service.</param>
    public AnotherExampleViewModel(INavigationService navigationService)
    {
      GoToMainPageCommand = new RelayCommand(NavigateToMainPage);
      this.navigationService = navigationService;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Navigates to the main page.
    /// </summary>
    private void NavigateToMainPage()
    {
      navigationService.Navigate<ExamplePage>();
    }
    #endregion
  }
}
