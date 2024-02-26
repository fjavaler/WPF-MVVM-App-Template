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
      // TODO: Fix this
      //var mainFrame = App.Current.MainWindow.FindName("MainFrame") as Frame;
      //mainFrame?.Navigate(ExamplePage);
    }
  }
}
