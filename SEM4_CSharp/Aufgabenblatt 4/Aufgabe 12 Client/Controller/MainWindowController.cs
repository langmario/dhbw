using Aufgabe_12_Client.Controller;
using Aufgabe_12_Client.CustomerServiceProxy;
using Aufgabe_12_Client.framework;
using Aufgabe_12_Client.viewmodel;
using Aufgabe_12_Client.views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Aufgabe_12_Client.controller
{
    class MainWindowController
    {
        MainWindowViewModel vm;
        CustomerServiceClient client = new CustomerServiceClient();


        private void ExecuteGetAll(object o)
        {
            ExecuteClear(o);
            Customer[] customers = client.GetAllCustomers();
            if (customers != null)
            {
                foreach (var c in customers)
                    vm.Customers.Add(c);
            }
        }

        private void ExecuteClear(object o)
        {
            vm.Customers.Clear();
        }


        private void ExecuteDelete(object o)
        {
            if (client.RemoveCustomer(vm.SelectedCustomer))
            {
                ExecuteGetAll(o);
            }
        }


        private void ExecuteGetByLastName(object o)
        {
            if (!string.IsNullOrEmpty(vm.SearchText))
            {
                ExecuteClear(o);
                string lastName = vm.SearchText;
                var customers = client.GetCustomers(lastName);
                if (customers != null)
                {
                    foreach (var c in customers)
                        vm.Customers.Add(c);
                }
            }
        }


        private void ExecuteNewCustomer(object o)
        {
            var controller = new AddWindowController();
            var customer = controller.AddCustomer();
            if (customer != null)
            {
                if (client.AddCustomer(customer))
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
                EmptyCommand = new RelayCommand(ExecuteClear, o => vm.Customers.Any()),
                DeleteCommand = new RelayCommand(ExecuteDelete, o => vm.SelectedCustomer != null),
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
