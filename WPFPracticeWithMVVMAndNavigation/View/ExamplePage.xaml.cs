using System.Diagnostics;
using System.Windows.Controls;
using WPFAppTemplate.Service;
using WPFAppTemplate.ViewModel;

namespace WPFAppTemplate.View
{
  /// <summary>
  /// Interaction logic for ExamplePage.xaml
  /// </summary>
  public partial class ExamplePage : Page
  {
    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="ExamplePage"/> class.
    /// </summary>
    /// <param name="viewModel">The view model.</param>
    public ExamplePage(ExampleViewModel viewModel)
    {
      InitializeComponent();
      DataContext = viewModel;
    }
    #endregion
  }
}
