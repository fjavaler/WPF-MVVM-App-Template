namespace WPFAppTemplate.Service.Abstract
{
  /// <summary>
  /// Interface for the Logging Service.
  /// </summary>
  public interface ILoggingService
  {
    #region Methods
    /// <summary>
    /// Logs a message.
    /// </summary>
    /// <param name="message">The message to log.</param>
    void Log(string message);

    /// <summary>
    /// Logs a message and an exception.
    /// </summary>
    /// <param name="message">The message to log.</param>
    /// <param name="exception">The exception to log.</param>
    void Log(string message, Exception exception);

    /// <summary>
    /// Logs an exception.
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    void Log(Exception exception);

    /// <summary>
    /// Logs a debug message.
    /// </summary>
    /// <param name="message">The message to log.</param>
    void LogDebug(string message);

    /// <summary>
    /// Logs a debug message and an exception.
    /// </summary>
    /// <param name="message">The message to log.</param>
    /// <param name="exception">The exception to log.</param>
    void LogDebug(string message, Exception exception);

    /// <summary>
    /// Logs a debug exception.
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    void LogDebug(Exception exception);

    /// <summary>
    /// Logs an error message.
    /// </summary>
    /// <param name="message">The message to log.</param>
    void LogError(string message);

    /// <summary>
    /// Logs an error message and an exception.
    /// </summary>
    /// <param name="message">The message to log.</param>
    /// <param name="exception">The exception to log.</param>
    void LogError(string message, Exception exception);

    /// <summary>
    /// Logs an error exception.
    /// </summary>
    /// <param name="exception">The exception to log.</param>
    void LogError(Exception exception);
    #endregion
  }
}
