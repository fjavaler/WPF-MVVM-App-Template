using System.Windows.Input;

namespace WPFAppTemplate.Commands
{
  /// <summary>
  /// Base command class that implements ICommand
  /// </summary>
  public abstract class BaseCommand : ICommand
  {
    /// <summary>
    /// Event that is raised when the CanExecute value changes
    /// </summary>
    public abstract event EventHandler? CanExecuteChanged;

    /// <summary>
    /// Method that is called to determine if the command can be executed
    /// </summary>
    /// <param name="parameter"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public abstract bool CanExecute(object? parameter);

    /// <summary>
    /// Method that is called when the command is executed
    /// </summary>
    /// <param name="parameter"></param>
    /// <exception cref="NotImplementedException"></exception>
    public abstract void Execute(object? parameter);
  }
}
