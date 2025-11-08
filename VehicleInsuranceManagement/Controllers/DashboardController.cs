using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VehicleInsuranceManagement.Controllers
{
    public class DashboardController : Controller
    {
        [Authorize(Roles = "admin, employee")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
