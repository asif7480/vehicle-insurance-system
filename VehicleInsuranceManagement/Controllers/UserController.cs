using Microsoft.AspNetCore.Mvc;

namespace VehicleInsuranceManagement.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
