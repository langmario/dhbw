using Aufgabe_11.Models;
using Aufgabe_11.ViewModels;
using Aufgabe_11.Views;
using Beispiel_1.Framework;

namespace Aufgabe_11.Controllers
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

        public Employee AddEmployee()
        {
            var vm = new WindowAddViewModel
            {
                Model = new Employee(),
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
