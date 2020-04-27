using Aufgabe_11.Framework;
using Aufgabe_11.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Aufgabe_11.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        private ObservableCollection<Employee> _employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees
        {
            get
            {
                return _employees;
            }
            set
            {
                _employees = value;
                OnPropertyChanged();
            }
        }

        private Employee _selectedEmployee;

        public Employee SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
    }
}
