using Aufgabe_13.Models;
using Aufgabe_13.ViewModels;
using Aufgabe_13.Views;
using Beispiel_1.Framework;

namespace Aufgabe_13.Controllers
{
    public class WindowAddController
    {
        private WindowAdd mView;


        private void ExecuteOkCommand(object o)
        {
            mView.DialogResult = true;
            mView.Close();
        }

        private void ExecuteCancelCommand(object o)
        {
            mView.DialogResult = false;
            mView.Close();
        }

        public Customer AddCustomer()
        {
            var vm = new WindowAddViewModel
            {
                Model = new Customer(),
                OkCommand = new RelayCommand(ExecuteOkCommand),
                CancelCommand = new RelayCommand(ExecuteCancelCommand)
            };

            mView = new WindowAdd
            {
                DataContext = vm
            };

            var result = mView.ShowDialog() ?? false;

            return result ? vm.Model : null;
        }
    }
}
