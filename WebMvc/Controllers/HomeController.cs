using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMvc.Models;
using WebMvc.Service.Interface;
using Shared.Models.Binding;

namespace WebMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVehicleService _vehicleService;

        public HomeController(ILogger<HomeController> logger, IVehicleService vehicleService)
        {
            _logger = logger;
            _vehicleService = vehicleService;
        }

        public IActionResult Index()
        {
            var vehicle = _vehicleService.AddVehicle(new VehicleBinding
            {
                GodinaProizvodnje=2025,
                Make="Opel",
                Model="Frontera"
            });
            var result = _vehicleService.GetAllVehicles();
            return View(result);
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
