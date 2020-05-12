using System.ComponentModel;

namespace Aufgabe_14.Framework
{
    public interface IViewModelBase
    {
        event PropertyChangedEventHandler PropertyChanged;
    }
}