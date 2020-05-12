using Aufgabe_13.Framework;
using Aufgabe_13.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Aufgabe_13.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        private ObservableCollection<Customer> _models = new ObservableCollection<Customer>();
        public ObservableCollection<Customer> Models
        {
            get
            {
                return _models;
            }
            set
            {
                _models = value;
                OnPropertyChanged();
            }
        }

        private Customer _selectedModel;
        public Customer SelectedModel
        {
            get => _selectedModel;
            set
            {
                _selectedModel = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
    }
}
