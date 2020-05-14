using Aufgabe_14.Controllers;
using Aufgabe_14.Models;
using Aufgabe_14.Repositories;
using Aufgabe_14.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Aufgabe_14_Test
{
    [TestClass]
    public class DatabaseAccessTests
    {

        [TestMethod]
        public void PersistGenrePositiveTest()
        {
            var genre = new Genre { Name = "Action" };

            var genreAddControllerMock = new Mock<IGenreAddController>();
            genreAddControllerMock.Setup(x => x.AddGenre()).Returns(() => genre);

            var repositoryMock = new Mock<IRepository<Genre>>();
            repositoryMock.Setup(x => x.Save(genre));


            var viewModelMock = new Mock<IMainWindowViewModel>();
            viewModelMock.Setup(x => x.ActiveViewModel).Returns(() => new GenresViewModel());

            var controller = new MainWindowController(null, repositoryMock.Object, null, genreAddControllerMock.Object, viewModelMock.Object, null, null);

            // Methoden im Controller sind private, können nicht getestet werden
        }
    }
}
