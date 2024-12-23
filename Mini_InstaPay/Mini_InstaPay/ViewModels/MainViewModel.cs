using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_InstaPay.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public object CurrentPageViewModel { get; set; }

        public MainViewModel()
        {
            // Initialize with WelcomePageViewModel
            CurrentPageViewModel = new WelcomePageViewModel();
        }

        public void NavigateToRegister()
        {
            CurrentPageViewModel = new RegisterViewModel();
        }

        public void NavigateToLogin()
        {
            CurrentPageViewModel = new LoginViewModel();
        }
    }
}
