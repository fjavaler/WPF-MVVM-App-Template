using System.Windows.Controls;
using WPFAppTemplate.ViewModel;

namespace WPFAppTemplate.View
{
  /// <summary>
  /// Interaction logic for AnotherExamplePage.xaml
  /// </summary>
  public partial class AnotherExamplePage : Page
  {
    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="AnotherExamplePage"/> class.
    /// </summary>
    /// <param name="viewModel">The view model.</param>
    public AnotherExamplePage(AnotherExampleViewModel viewModel)
    {
      InitializeComponent();
      DataContext = viewModel;
    }
    #endregion
  }
}