using System.Windows;
using WPFPracticeWithMVVMAndNavigation.View;

namespace WPFPracticeWithMVVMAndNavigation
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow(ExamplePage examplePage)
    {
      InitializeComponent();
      MainFrame?.Navigate(examplePage);
    }
  }
}
