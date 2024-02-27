using System.Windows.Controls;
using WPFAppTemplate.ViewModel;

namespace WPFAppTemplate.View
{
  /// <summary>
  /// Interaction logic for AnotherExamplePage.xaml
  /// </summary>
  public partial class AnotherExamplePage : Page
  {
    public AnotherExamplePage(AnotherExampleViewModel viewModel)
    {
      InitializeComponent();
      DataContext = viewModel;
    }
  }
}