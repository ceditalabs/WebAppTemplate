using System.Diagnostics;
using $ext_safeprojectname$.Abstractions;
using $safeprojectname$.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace $safeprojectname$.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IPrimeNumberDeterminator primeNumberDeterminator;

        public HomeController(ILogger<HomeController> logger, IPrimeNumberDeterminator primeNumberDeterminator)
        {
            this.logger = logger;
            this.primeNumberDeterminator = primeNumberDeterminator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PrimeViewModel primeViewModel)
        {
            primeViewModel.IsPrime = primeNumberDeterminator.IsPrime(primeViewModel.Number);

            return View(primeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
