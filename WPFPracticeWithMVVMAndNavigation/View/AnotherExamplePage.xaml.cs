using System.Windows.Controls;
using WPFPracticeWithMVVMAndNavigation.ViewModel;

namespace WPFPracticeWithMVVMAndNavigation.View
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