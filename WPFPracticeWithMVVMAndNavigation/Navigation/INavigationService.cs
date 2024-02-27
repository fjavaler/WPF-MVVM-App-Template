
namespace WPFPracticeWithMVVMAndNavigation.Navigation
{
  public interface INavigationService
  {
    IServiceProvider ServiceProvider { get; set; }

    void Navigate<T>();
  }
}