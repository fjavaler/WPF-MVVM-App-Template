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
      Console.WriteLine(message);
    }

    /// <inheritdoc/>
    public void Log(string message, Exception exception)
    {
      Console.WriteLine(message, exception);
    }

    /// <inheritdoc/>
    public void Log(Exception exception)
    {
      Console.WriteLine(exception);
    }

    /// <inheritdoc/>
    public void LogDebug(string message)
    {
      Debug.WriteLine(message);
    }

    /// <inheritdoc/>
    public void LogDebug(string message, Exception exception)
    {
      Debug.WriteLine(message, exception);
    }

    /// <inheritdoc/>
    public void LogDebug(Exception exception)
    {
      Debug.WriteLine(exception);
    }

    /// <inheritdoc/>
    public void LogError(string message)
    {
      Console.Error.WriteLine(message);
    }

    /// <inheritdoc/>
    public void LogError(string message, Exception exception)
    {
      Console.Error.WriteLine(message, exception);
    }

    /// <inheritdoc/>
    public void LogError(Exception exception)
    {
      Console.Error.WriteLine(exception);
    }
    #endregion
  }
}
