using System.Windows.Input;
using WPFAppTemplate.Commands;
using WPFAppTemplate.Navigation;
using WPFAppTemplate.Service;
using WPFAppTemplate.View;

namespace WPFAppTemplate.ViewModel
{
  public class ExampleViewModel : ViewModelBase
  {
    #region Commands
    public ICommand LoadDataCommand { get; private set; }
    public ICommand GoToAnotherPageCommand { get; private set; }
    #endregion

    #region Properties
    public string ButtonText { get; set; } = "Load Data";

    private readonly IDataService _dataService;
    private readonly INavigationService _navigationService;
    private readonly AnotherExamplePage _anotherExamplePage;

    public ExampleViewModel(IDataService dataService, INavigationService navigationService, AnotherExamplePage anotherExamplePage)
    {
      _dataService = dataService;
      _anotherExamplePage = anotherExamplePage;
      _navigationService = navigationService;

      LoadDataCommand = new RelayCommand(LoadData);
      GoToAnotherPageCommand = new RelayCommand(GoToAnotherPage);
    }

    private string data = string.Empty;

    public string Data
    {
      get { return data; }
      set
      {
        data = value;
        OnPropertyChanged(nameof(data));
      }
    }
    #endregion

    #region Methods
    private void LoadData()
    {
      if (Data != string.Empty)
      {
        Data = string.Empty;
      }

      Data = _dataService.GetData().Text;
    }

    private void GoToAnotherPage()
    {
      _navigationService.Navigate<AnotherExamplePage>();
    }
    #endregion
  }
}