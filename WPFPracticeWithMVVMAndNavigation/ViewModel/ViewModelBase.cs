using System.ComponentModel;

namespace WPFAppTemplate.ViewModel
{
  /// <summary>
  /// Base class for all view models.
  /// </summary>
  public class ViewModelBase : INotifyPropertyChanged
  {
    #region Events
    /// <summary>
    /// Event that is raised when a property is changed.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;
    #endregion

    #region Methods
    /// <summary>
    /// Raises the PropertyChanged event.
    /// </summary>
    /// <param name="propertyName"></param>
    protected virtual void OnPropertyChanged(string propertyName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion
  }
}
