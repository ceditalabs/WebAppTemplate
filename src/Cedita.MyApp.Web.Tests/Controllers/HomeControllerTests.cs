using $ext_safeprojectname$.Services;
using $ext_safeprojectname$.Web.Controllers;
using $ext_safeprojectname$.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace $safeprojectname$
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_ShouldWorkWithNonPrime()
        {
            var mockLogger = new Mock<ILogger<HomeController>>();
            var primeNumberDeterminator = new PrimeNumberDeterminator();

            var homeController = new HomeController(mockLogger.Object, primeNumberDeterminator);

            var result = homeController.Index(new PrimeViewModel { Number = 1 });

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<PrimeViewModel>(viewResult.ViewData.Model);

            Assert.Equal(1, model.Number);
            Assert.False(model.IsPrime);
        }
    }
}
