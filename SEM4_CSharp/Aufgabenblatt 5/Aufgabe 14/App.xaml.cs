using Aufgabe_14.Controllers;
using Aufgabe_14.Models;
using Aufgabe_14.Repositories;
using Aufgabe_14.ViewModel;
using Aufgabe_14.Views;
using Autofac;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace Aufgabe_14
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var builder = new ContainerBuilder();

            // CONTROLLERS
            builder.RegisterType<MainWindowController>();
            builder.RegisterType<GenreAddController>().As<IGenreAddController>();
            builder.RegisterType<MovieAddController>().As<IMovieAddController>();

            // VIEWMODELS
            builder.RegisterType<GenreAddViewModel>().As<IGenreAddViewModel>();
            builder.RegisterType<MovieAddViewModel>().As<IMovieAddViewModel>();
            builder.RegisterType<MoviesViewModel>().As<IMoviesViewModel>();
            builder.RegisterType<GenresViewModel>().As<IGenresViewModel>();
            builder.RegisterType<MainWindowViewModel>().As<IMainWindowViewModel>();

            // REPOSITORIES
            builder.RegisterType<MovieRepository>().As<IRepository<Movie>>();
            builder.RegisterType<GenreRepository>().As<IRepository<Genre>>();


            var container = builder.Build();

            var controller = container.Resolve<MainWindowController>();

            container.Dispose();
        }
    }
}
