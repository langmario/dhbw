using Aufgabe_14.Framework;
using System.Windows.Input;

namespace Aufgabe_14.ViewModel
{
    public interface IMainWindowViewModel : IViewModelBase
    {
        IViewModelBase ActiveViewModel { get; set; }
        ICommand AddCommand { get; set; }
        ICommand ChangeViewCommand { get; set; }
        ICommand DeleteCommand { get; set; }
    }
}