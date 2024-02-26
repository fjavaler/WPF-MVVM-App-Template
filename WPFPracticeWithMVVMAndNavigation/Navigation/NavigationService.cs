using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFPracticeWithMVVMAndNavigation.Navigation
{
  public class NavigationService : INavigationService
  {
    public void NavigateTo(string uri)
    {
      // TODO: test to see if this works.
      var mainFrame = App.Current.MainWindow.FindName("MainFrame") as Frame;
      mainFrame?.Navigate(new Uri(uri, UriKind.Relative));
    }
  }
}
