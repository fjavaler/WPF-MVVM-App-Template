using System.Windows;
using WPFAppTemplate.View;

namespace WPFAppTemplate
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
