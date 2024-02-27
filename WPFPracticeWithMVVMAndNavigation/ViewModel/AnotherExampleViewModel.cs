using System.Windows.Input;
using WPFPracticeWithMVVMAndNavigation.Commands;
using WPFPracticeWithMVVMAndNavigation.Navigation;
using WPFPracticeWithMVVMAndNavigation.View;

namespace WPFPracticeWithMVVMAndNavigation.ViewModel
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
