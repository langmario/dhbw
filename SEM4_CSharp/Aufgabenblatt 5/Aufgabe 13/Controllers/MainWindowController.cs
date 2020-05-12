using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aufgabe_13.Framework;
using Aufgabe_13.Models;
using Aufgabe_13.ViewModels;
using Aufgabe_13.Views;
using Beispiel_1.Framework;

namespace Aufgabe_13.Controllers
{
    public class MainWindowController
    {
        private MainWindowViewModel _viewModel;
        private Repository<Customer> _customerRepository;


        private void ExecuteAddCommand(object o)
        {
            var addController = new WindowAddController();
            var customer = addController.AddCustomer();

            if (customer != null)
            {
                _customerRepository.Save(customer);
                _viewModel.Models.Add(customer);
            }
        }

        private void ExecuteDeleteCommand(object o)
        {
            if (_viewModel.SelectedModel != null)
            {
                _customerRepository.Delete(_viewModel.SelectedModel);
                _viewModel.Models.Remove(_viewModel.SelectedModel);
            }
        }

        private bool CanExecuteDeleteCommand(object o)
        {
            return _viewModel.SelectedModel != null;
        }


        public void Initialize()
        {
            _customerRepository = new Repository<Customer>(@"Database\CustomerSample.db");
            _viewModel = new MainWindowViewModel
            {
                AddCommand = new RelayCommand(ExecuteAddCommand),
                DeleteCommand = new RelayCommand(ExecuteDeleteCommand, CanExecuteDeleteCommand),
                Models = new ObservableCollection<Customer>(_customerRepository.GetAll())
            };
            var view = new MainWindow
            {
                DataContext = _viewModel
            };

            view.Show();
        }
    }
}
