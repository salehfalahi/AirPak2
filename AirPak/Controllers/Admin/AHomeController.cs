using System.Text.Json;
using AirPak.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AirPak.Controllers.Admin
{
    [Authorize(Roles = "admin")]
    public class AHomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ManageHeader()
        {
            return View();
        }

    }
 
}



