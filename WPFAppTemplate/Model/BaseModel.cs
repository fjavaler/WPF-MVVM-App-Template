using System.ComponentModel;

namespace WPFAppTemplate.Model
{
  public class BaseModel : INotifyPropertyChanged
  {
    #region Events
    /// <summary>
    /// Event that is raised when a property is changed.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;
    #endregion

    #region Methods
    /// <summary>
    /// Raises the PropertyChanged event.
    /// </summary>
    /// <param name="propertyName"></param>
    public void OnPropertyChanged(string propertyName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion
  }
}
