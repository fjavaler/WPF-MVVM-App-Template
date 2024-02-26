using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPracticeWithMVVMAndNavigation.Navigation
{
  public interface INavigationService
  {
    public void NavigateTo(string uri);
  }
}
