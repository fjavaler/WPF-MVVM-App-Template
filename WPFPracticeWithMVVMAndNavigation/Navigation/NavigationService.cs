using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPracticeWithMVVMAndNavigation.Navigation
{
  public class NavigationService : INavigationService
  {
    public IServiceProvider ServiceProvider { get; set; }
    public NavigationService(IServiceProvider serviceProvider)
    {
      ServiceProvider = serviceProvider;
    }

    public void Navigate<T>()
    {
      var page = ServiceProvider.GetService(typeof(T));
      var mainFrame = App.Current.MainWindow.FindName("MainFrame") as System.Windows.Controls.Frame;
      mainFrame?.Navigate(page);
    }
  }
}
