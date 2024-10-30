using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AirPak.Controllers.Customer
{
    [Authorize(Roles = "customer")]
    public class CHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
