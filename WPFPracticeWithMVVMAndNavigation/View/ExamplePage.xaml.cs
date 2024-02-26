using System.Diagnostics;
using System.Windows.Controls;
using WPFPracticeWithMVVMAndNavigation.Service;
using WPFPracticeWithMVVMAndNavigation.ViewModel;

namespace WPFPracticeWithMVVMAndNavigation.View
{
  /// <summary>
  /// Interaction logic for ExamplePage.xaml
  /// </summary>
  public partial class ExamplePage : Page
  {
    public ExamplePage(ExampleViewModel viewModel)
    {
      InitializeComponent();
      DataContext = viewModel;
    }
  }
}
