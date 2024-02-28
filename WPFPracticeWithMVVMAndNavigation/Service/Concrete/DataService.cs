using WPFAppTemplate.Model;
using WPFAppTemplate.Service.Abstract;

namespace WPFAppTemplate.Service.Concrete
{
  /// <summary>
  /// A concrete implementation of the data service.
  /// </summary>
  public class DataService : IDataService
  {
    #region Methods
    /// <inheritdoc/>
    public ExampleModel GetData()
    {
      // Logic to fetch data from a data source
      return new ExampleModel { Text = "Hello, MVVM!" };
    }
    #endregion
  }
}
