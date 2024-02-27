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
    public ExamplePage(ExampleViewModel viewModel)
    {
      InitializeComponent();
      DataContext = viewModel;
    }
  }
}
