using Aufgabe_12_Client.CustomerServiceProxy;
using Aufgabe_12_Client.framework;
using Aufgabe_12_Client.viewmodel;
using Aufgabe_12_Client.views;

namespace Aufgabe_12_Client.Controller
{
    internal class AddWindowController
    {
        private AddWindow window;
        private AddWindowViewModel vm;

        public Customer AddCustomer()
        {
            vm = new AddWindowViewModel
            {
                CancelCommand = new RelayCommand(o => window.Close()),
                OkCommand = new RelayCommand(o => { window.DialogResult = true; window.Close(); })
            };

            window = new AddWindow
            {
                DataContext = vm
            };

            var result = window.ShowDialog() ?? false;

            return !string.IsNullOrEmpty(vm.FirstName) || !string.IsNullOrEmpty(vm.LastName)
                ? result ? vm.Customer : null
                : null;
        }
    }
}
