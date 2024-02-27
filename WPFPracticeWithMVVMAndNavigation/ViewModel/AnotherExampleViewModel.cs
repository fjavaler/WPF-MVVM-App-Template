using System.Windows.Input;
using WPFAppTemplate.Commands;
using WPFAppTemplate.Navigation;
using WPFAppTemplate.View;

namespace WPFAppTemplate.ViewModel
{
  public class AnotherExampleViewModel
  {
    private readonly INavigationService navigationService;

    public ICommand GoToMainPageCommand { get; private set; }

    public AnotherExampleViewModel(INavigationService navigationService)
    {
      GoToMainPageCommand = new RelayCommand(NavigateToMainPage);
      this.navigationService = navigationService;
    }

    private void NavigateToMainPage()
    {
      navigationService.Navigate<ExamplePage>();
    }
  }
}
