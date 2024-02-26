using System.Windows.Input;
using WPFPracticeWithMVVMAndNavigation.Commands;

namespace WPFPracticeWithMVVMAndNavigation.ViewModel
{
  public class AnotherExampleViewModel
  {
    public ICommand GoToMainPageCommand { get; set; }

    public AnotherExampleViewModel()
    {
      GoToMainPageCommand = new RelayCommand(NavigateToMainPage);
    }

    private void NavigateToMainPage()
    {
    }
  }
}
