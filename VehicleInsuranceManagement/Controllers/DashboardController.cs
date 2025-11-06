using Microsoft.AspNetCore.Mvc;

namespace VehicleInsuranceManagement.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
