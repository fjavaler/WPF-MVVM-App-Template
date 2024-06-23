using System.Globalization;
using System.Windows.Data;

namespace WPFAppTemplate.Converters
{
  /// <summary>
  /// Base class for all converters.
  /// </summary>
  public abstract class BaseConverter : IValueConverter
  {
    #region IValueConverter Members
    /// <summary>
    /// Converts a value.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="targetType">The target type.</param>
    /// <param name="parameter">A parameter.</param>
    /// <param name="culture">Culture info.</param>
    /// <returns>A converted object.</returns>
    public abstract object Convert(object? value, Type targetType, object? parameter, CultureInfo culture);

    /// <summary>
    /// Converts a value back.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="targetType">The target type.</param>
    /// <param name="parameter">A parameter.</param>
    /// <param name="culture">Culture info.</param>
    /// <returns>A converted back object.</returns>
    public abstract object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture);
    #endregion
  }
}
