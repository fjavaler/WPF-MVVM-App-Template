using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFPracticeWithMVVMAndNavigation.Commands;
using WPFPracticeWithMVVMAndNavigation.Service;
using WPFPracticeWithMVVMAndNavigation.View;

namespace WPFPracticeWithMVVMAndNavigation.ViewModel
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

    public ExampleViewModel(IDataService dataService)
    {
      _dataService = dataService;
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
    }
    #endregion
  }
}