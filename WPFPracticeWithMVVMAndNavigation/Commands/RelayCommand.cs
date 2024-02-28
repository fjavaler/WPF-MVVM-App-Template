using System.Windows.Input;

namespace WPFAppTemplate.Commands
{
  /// <summary>
  /// A command that can be executed.
  /// </summary>
  public class RelayCommand : ICommand
  {
    #region Fields
    /// <summary>
    /// The action to run when the command is executed.
    /// </summary>
    private readonly Action _execute;

    /// <summary>
    /// The function to run to determine if the command can be executed.
    /// </summary>
    private readonly Func<bool> _canExecute;

    /// <summary>
    /// The event that is fired when the <see cref="CanExecute(object)"/> value changes.
    /// </summary>
    public event EventHandler CanExecuteChanged;
    #endregion

    #region Constructors
    /// <summary>
    /// Creates an instance of <see cref="RelayCommand"/>.
    /// </summary>
    /// <param name="execute">An action to execute.</param>
    /// <param name="canExecute">Whether the action can execute.</param>
    /// <exception cref="ArgumentNullException">Exception.</exception>
    public RelayCommand(Action execute, Func<bool> canExecute = null)
    {
      _execute = execute ?? throw new ArgumentNullException(nameof(execute));
      _canExecute = canExecute;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Determines if the command can be executed.
    /// </summary>
    /// <param name="parameter">Parameter.</param>
    /// <returns>True if can execute.</returns>
    public bool CanExecute(object parameter)
    {
      return _canExecute?.Invoke() ?? true;
    }

    /// <summary>
    /// Executes the command.
    /// </summary>
    /// <param name="parameter">Parameter.</param>
    public void Execute(object parameter)
    {
      _execute();
    }

    /// <summary>
    /// Raises the <see cref="CanExecuteChanged"/> event.
    /// </summary>
    public void RaiseCanExecuteChanged()
    {
      CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
    #endregion
  }
}
