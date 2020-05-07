using Aufgabe_12_Client.CustomerServiceProxy;
using System.Windows.Input;

namespace Aufgabe_12_Client.viewmodel
{
    internal class AddWindowViewModel : ViewModelBase
    {

        public Customer Customer { get; set; } = new Customer();
        public string FirstName
        {
            get => Customer.FirstName;
            set
            {
                Customer.FirstName = value;
                OnPropertyChanged();
            }
        }
        public string LastName
        {
            get => Customer.LastName;
            set
            {
                Customer.LastName = value;
                OnPropertyChanged();
            }
        }

        public ICommand OkCommand { get; set; }
        public ICommand CancelCommand { get; set; }
    }
}
