using System.Windows.Input;

namespace Aufgabe_12_Client.viewmodel
{
    class AddWindowViewModel : ViewModelBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICommand OkCommand { get; set; }
        public ICommand CancelCommand { get; set; }
    }
}
