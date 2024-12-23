using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mini_InstaPay.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public ICommand SubmitCommand { get; }

        public RegisterViewModel()
        {
            SubmitCommand = new RelayCommand(_ => Submit());
        }

        private void Submit()
        {
            // Handle registration logic
        }
    }
}
