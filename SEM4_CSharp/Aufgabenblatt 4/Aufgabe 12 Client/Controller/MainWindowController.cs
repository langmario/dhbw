using Aufgabe_12_Client.Controller;
using Aufgabe_12_Client.CustomerServiceProxy;
using Aufgabe_12_Client.framework;
using Aufgabe_12_Client.viewmodel;
using Aufgabe_12_Client.views;
using System.Collections.ObjectModel;
using System.Linq;

namespace Aufgabe_12_Client.controller
{
    internal class MainWindowController
    {
        private MainWindowViewModel vm;
        private readonly CustomerServiceClient client = new CustomerServiceClient();


        private async void ExecuteGetAll(object o)
        {
            ExecuteClear(o);
            var customers = await client.GetAllCustomersAsync();
            vm.Customers = new ObservableCollection<Customer>(customers);
        }

        private void ExecuteClear(object o)
        {
            vm.Customers?.Clear();
        }


        private async void ExecuteDelete(object o)
        {
            if (await client.RemoveCustomerAsync(vm.SelectedCustomer))
            {
                ExecuteGetAll(o);
            }
        }


        private async void ExecuteGetByLastName(object o)
        {
            if (!string.IsNullOrEmpty(vm.SearchText))
            {
                ExecuteClear(o);
                string lastName = vm.SearchText;
                var customers = await client.GetCustomersAsync(lastName);
                vm.Customers = new ObservableCollection<Customer>(customers);
            }
            else
            {
                ExecuteGetAll(o);
            }
        }


        private async void ExecuteNewCustomer(object o)
        {
            var controller = new AddWindowController();
            var customer = controller.AddCustomer();
            if (customer != null)
            {
                if (await client.AddCustomerAsync(customer))
                {
                    ExecuteGetAll(o);
                }
            }
        }


        public void Initialize()
        {
            vm = new MainWindowViewModel
            {
                SearchCommand = new RelayCommand(ExecuteGetByLastName),
                LoadCommand = new RelayCommand(ExecuteGetAll),
                EmptyCommand = new RelayCommand(ExecuteClear, _ => vm.Customers?.Any() ?? false),
                DeleteCommand = new RelayCommand(ExecuteDelete, _ => vm.SelectedCustomer != null),
                NewCommand = new RelayCommand(ExecuteNewCustomer)
            };

            MainWindow window = new MainWindow
            {
                DataContext = vm
            };

            window.Show();
        }
    }
}
