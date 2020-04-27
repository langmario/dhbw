using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aufgabe_11.Models;
using Aufgabe_11.ViewModels;
using Aufgabe_11.Views;
using Beispiel_1.Framework;

namespace Aufgabe_11.Controllers
{
    public class MainWindowController
    {
        private MainWindowViewModel mViewModel;


        private void ExecuteAddCommand(object o)
        {
            var addController = new WindowAddController();
            var employee = addController.AddEmployee();
            if (employee != null)
            {
                mViewModel.Employees.Add(employee);
            }
        }

        private void ExecuteDeleteCommand(object o)
        {
            if (mViewModel.SelectedEmployee != null)
            {
                mViewModel.Employees.Remove(mViewModel.SelectedEmployee);
            }
        }

        private bool CanExecuteDeleteCommand(object o)
        {
            return mViewModel.SelectedEmployee != null;
        }


        public void Initialize()
        {
            mViewModel = new MainWindowViewModel
            {
                AddCommand = new RelayCommand(ExecuteAddCommand),
                DeleteCommand = new RelayCommand(ExecuteDeleteCommand, CanExecuteDeleteCommand),
                Employees = new ObservableCollection<Employee>
                {
                    new Employee
                    {
                        Firstname = "John",
                        Surname = "Doe",
                        Gender = Gender.Male,
                        Address = new Address
                        {
                            StreetNumber = "123",
                            PostCode = 12345,
                            City = "Testcity",
                            Street = "Teststreet"
                        }
                    },
                    new Employee
                    {
                        Firstname = "Jane",
                        Surname = "Doe",
                        Gender = Gender.Female,
                        Address = new Address
                        {
                            StreetNumber = "123",
                            PostCode = 12345,
                            City = "Testcity",
                            Street = "Teststreet"
                        }
                    },
                }
            };
            var view = new MainWindow
            {
                DataContext = mViewModel
            };

            view.Show();
        }
    }
}
