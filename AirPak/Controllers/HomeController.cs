using AirPak.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BLL;

namespace AirPak.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
         //AppDbContext dbContext = new AppDbContext();

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public async Task<IActionResult> IndexAsync()
		{
            blProduct blProduct = new blProduct();
            var data = await blProduct.ReadAsync();
            ViewBag.Products = data.ToList();
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
        public async Task<IActionResult> About()
        {
            //blProduct blProduct = new blProduct();
            //var data = await blProduct.ReadAsync();
            //ViewBag.Products = data.ToList();
            return View();
        }
        public IActionResult AboutProduct()
        {
         
            return View();
        }public IActionResult Contact()
        {
         
            return View();
        }
    }
}