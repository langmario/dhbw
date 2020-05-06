using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Aufgabe_12_Client.viewmodel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<CustomerServiceProxy.Customer> Customers { get; set; } = new ObservableCollection<CustomerServiceProxy.Customer>();
        private CustomerServiceProxy.Customer _selectedCustomer = null;
        public CustomerServiceProxy.Customer SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                if (value != _selectedCustomer)
                {
                    _selectedCustomer = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _searchText = string.Empty;
        public string SearchText
        {
            get => _searchText;
            set
            {
                if (value != _searchText)
                {
                    _searchText = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand SearchCommand { get; set; }
        public ICommand LoadCommand { get; set; }
        public ICommand EmptyCommand { get; set; }
        public ICommand NewCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
    }
}
