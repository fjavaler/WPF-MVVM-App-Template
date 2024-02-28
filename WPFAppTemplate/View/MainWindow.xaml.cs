using System.Windows;
using WPFAppTemplate.View;

namespace WPFAppTemplate
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="MainWindow"/> class.
    /// </summary>
    /// <param name="examplePage">The view model.</param>
    public MainWindow(ExamplePage examplePage)
    {
      InitializeComponent();
      MainFrame?.Navigate(examplePage);
    }
    #endregion
  }
}
