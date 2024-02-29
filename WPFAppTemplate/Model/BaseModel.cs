using System.ComponentModel;
using System.Runtime.CompilerServices;

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
    /// Sets field to newValue for property, propertyName, and raises
    /// property changed event.
    /// </summary>
    /// <typeparam name="T">Generic type.</typeparam>
    /// <param name="field">field to update.</param>
    /// <param name="newValue">The new value.</param>
    /// <param name="propertyName">The name of the property being updated.</param>
    /// <returns>True if setting of property succeeded.</returns>
    public bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
    {
      if (EqualityComparer<T>.Default.Equals(field, newValue))
      {
        return false;
      }

      field = newValue;
      OnPropertyChanged(propertyName);
      return true;
    }

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
