using Aufgabe_13.Controllers;
using System.Windows;

namespace Aufgabe_13
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var controller = new MainWindowController();
            controller.Initialize();
        }
    }
}
