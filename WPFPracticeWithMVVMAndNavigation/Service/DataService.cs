using WPFAppTemplate.Model;

namespace WPFAppTemplate.Service
{
  public class DataService : IDataService
  {
    public ExampleModel GetData()
    {
      // Logic to fetch data from a data source
      return new ExampleModel { Text = "Hello, MVVM!" };
    }
  }
}
