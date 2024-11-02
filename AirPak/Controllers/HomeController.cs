using AirPak.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BLL;

namespace AirPak.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly UrlEncryptionService _urlEncryptionService;

 


        public HomeController(ILogger<HomeController> logger , UrlEncryptionService urlEncryptionService)
		{
			_logger = logger;
            _urlEncryptionService = urlEncryptionService;
        }
 
      

        public async Task<IActionResult> IndexAsync()
		{
            blProduct blProduct = new blProduct();
            var data = await blProduct.ReadAsync();
            ViewBag.Products = data.ToList();
            return View();
        }
        public IActionResult CreateMessage(Models.Message message)
        {
            blMessage blM = new blMessage();
            BE.Message message1 = new BE.Message();
            message1.Name = message.Name;
                message1.Description = message.Description;
            message1.Email = message.Email;
             blM.Create(message1);
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
        }
        public IActionResult Contact()
        {
         
            return View();
        }
    }
}