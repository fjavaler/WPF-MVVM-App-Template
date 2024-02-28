using System.Globalization;
using System.Windows;

namespace WPFAppTemplate.Converters
{
  /// <summary>
  /// A converter class that converts a boolean value to a visibility value.
  /// </summary>
  public class BooleanToVisibilityConverter : BaseConverter
  {
    #region Methods
    /// <inheritdoc />
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      var booleanValue = (bool)value;
      if (booleanValue)
      {
        return Visibility.Visible;
      }

      return Visibility.Hidden;
    }

    /// <inheritdoc />
    public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
    #endregion
  }
}
