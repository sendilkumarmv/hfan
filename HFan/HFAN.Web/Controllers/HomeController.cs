using HFAN.Web.Models;
using HFAN.Web.ServiceClients;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HFAN.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICustomerApplicationService _customerApplicationService;
        public HomeController(ILogger<HomeController> logger, ICustomerApplicationService customerApplicationService)
        {
            _logger = logger;
            _customerApplicationService = customerApplicationService;
        }

        public IActionResult Index()
        {
            var cu = _customerApplicationService.Get();
            return View();
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