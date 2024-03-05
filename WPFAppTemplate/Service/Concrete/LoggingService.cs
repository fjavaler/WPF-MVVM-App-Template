using System.Diagnostics;
using WPFAppTemplate.Service.Abstract;

namespace WPFAppTemplate.Service.Concrete
{
  /// <summary>
  /// A service for logging messages and exceptions.
  /// </summary>
  public class LoggingService : ILoggingService
  {
    #region Methods
    /// <inheritdoc/>
    public void Log(string message)
    {
      Console.WriteLine("> " + message);
    }

    /// <inheritdoc/>
    public void Log(string message, Exception exception)
    {
      Console.WriteLine("> " + message, exception);
    }

    /// <inheritdoc/>
    public void Log(Exception exception)
    {
      Console.WriteLine("> " + exception);
    }

    /// <inheritdoc/>
    public void LogDebug(string message)
    {
      Debug.WriteLine("> Debug: " + message);
    }

    /// <inheritdoc/>
    public void LogDebug(string message, Exception exception)
    {
      Debug.WriteLine("> Debug: " + message, exception);
    }

    /// <inheritdoc/>
    public void LogDebug(Exception exception)
    {
      Debug.WriteLine("> Debug: " + exception);
    }

    /// <inheritdoc/>
    public void LogError(string message)
    {
      Debug.WriteLine("> ERROR: " + message);
    }

    /// <inheritdoc/>
    public void LogError(string message, Exception exception)
    {
      Debug.WriteLine("> ERROR: " + message, exception);
    }

    /// <inheritdoc/>
    public void LogError(Exception exception)
    {
      Debug.WriteLine("> ERROR: " + exception);
    }
    #endregion
  }
}
