using Aufgabe_14.Framework;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Aufgabe_14.ViewModel
{
	public class MainWindowViewModel : ViewModelBase, IMainWindowViewModel
	{
		private IViewModelBase _activeViewModel;
		public IViewModelBase ActiveViewModel
		{
			get => _activeViewModel;
			set => Set(ref _activeViewModel, value);
		}

		public ICommand ChangeViewCommand { get; set; }
		public ICommand AddCommand { get; set; }
		public ICommand DeleteCommand { get; set; }
	}
}
