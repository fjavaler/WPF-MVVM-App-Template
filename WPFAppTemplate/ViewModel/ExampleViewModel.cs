using System.Windows.Input;
using WPFAppTemplate.Commands;
using WPFAppTemplate.Navigation.Abstract;
using WPFAppTemplate.Service.Abstract;
using WPFAppTemplate.View;

namespace WPFAppTemplate.ViewModel
{
  /// <summary>
  /// View model for the ExamplePage.
  /// </summary>
  public class ExampleViewModel : ObservableObject
  {
    #region Commands
    /// <summary>
    /// Command to load data.
    /// </summary>
    public ICommand LoadDataCommand { get; private set; }

    /// <summary>
    /// Command to navigate to another page.
    /// </summary>
    public ICommand GoToAnotherPageCommand { get; private set; }
    #endregion

    #region Properties
    /// <summary>
    /// Text for the button.
    /// </summary>
    public string ButtonText { get; set; } = "Load Data";

    /// <summary>
    /// Data to display.
    /// </summary>
    private string data = string.Empty;

    /// <summary>
    /// Gets or sets the data.
    /// </summary>
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

    #region Fields
    /// <summary>
    /// Data service.
    /// </summary>
    private readonly IDataService _dataService;

    /// <summary>
    /// Navigation service.
    /// </summary>
    private readonly INavigationService _navigationService;

    /// <summary>
    /// Another example page.
    /// </summary>
    private readonly AnotherExamplePage _anotherExamplePage;
    #endregion

    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="ExampleViewModel"/> class.
    /// </summary>
    /// <param name="dataService">The data service.</param>
    /// <param name="navigationService">The navigation service.</param>
    /// <param name="anotherExamplePage">Another example page.</param>
    public ExampleViewModel(IDataService dataService, INavigationService navigationService, AnotherExamplePage anotherExamplePage)
    {
      _dataService = dataService;
      _anotherExamplePage = anotherExamplePage;
      _navigationService = navigationService;

      LoadDataCommand = new RelayCommand(LoadData);
      GoToAnotherPageCommand = new RelayCommand(GoToAnotherPage);
    }
    #endregion

    #region Methods
    /// <summary>
    /// Loads the data.
    /// </summary>
    private void LoadData()
    {
      if (Data != string.Empty)
      {
        Data = string.Empty;
      }

      Data = _dataService.GetData().Text ?? string.Empty;
    }

    /// <summary>
    /// Navigates to another page.
    /// </summary>
    private void GoToAnotherPage()
    {
      _navigationService.Navigate<AnotherExamplePage>();
    }
    #endregion
  }
}