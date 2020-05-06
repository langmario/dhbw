using Aufgabe_12_Client.framework;
using Aufgabe_12_Client.viewmodel;
using Aufgabe_12_Client.views;

namespace Aufgabe_12_Client.Controller
{
    public class AddWindowController
    {
        private AddWindow window;

        public CustomerServiceProxy.Customer AddCustomer()
        {
            AddWindowViewModel vm = new AddWindowViewModel
            {
                CancelCommand = new RelayCommand(o => window.Close()),
                OkCommand = new RelayCommand(o => { window.DialogResult = true; window.Close(); }),
            };

            window = new AddWindow
            {
                DataContext = vm
            };

            var result = window.ShowDialog() ?? false;

            return result ? new CustomerServiceProxy.Customer { FirstName = vm.FirstName, LastName = vm.LastName } : null;
        }
    }
}
