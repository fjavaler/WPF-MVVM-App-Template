using System.Globalization;
using System.Windows.Data;

namespace WpfAppTemplate.Converters
{
  /// <summary>
  /// A converter class that inverts the boolean value of a property. 
  /// </summary>
  public class InverseBooleanConverter : IValueConverter
  {
    /// <summary>
    /// Conversion method required for IValueConverter implementation.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="targetType">The target's class type.</param>
    /// <param name="parameter">Parameter.</param>
    /// <param name="culture">I'm not sure but is unused.</param>
    /// <returns>Inverted boolean value.</returns>
    /// <exception cref="ArgumentException">Thrown if value is not a bool.</exception>
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      bool isBool = value is bool;
      if (isBool)
      {
        return !(bool)value;
      }
      else
      {
        throw new ArgumentException($"{value} must be of type bool.");
      }
    }

    /// <summary>
    /// Converts value back to original type.
    /// </summary>
    /// <param name="value">The value to convert back.</param>
    /// <param name="targetType">The target's class type.</param>
    /// <param name="parameter">Parameter.</param>
    /// <param name="culture">Culture info.</param>
    /// <returns>Re-inverted boolean value.</returns>
    /// <exception cref="NotImplementedException">Not implemented (not needed).</exception>
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}