using WPFAppTemplate.Model;

namespace WPFAppTemplate.Service.Abstract
{
  /// <summary>
  /// Interface for the data service.
  /// </summary>
  public interface IDataService
  {
    #region Methods
    /// <summary>
    /// Get data.
    /// </summary>
    /// <returns>An Example model.</returns>
    ExampleModel GetData();
    #endregion
  }
}