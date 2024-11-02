using BE;
using BLL;
using Microsoft.AspNetCore.Mvc;

namespace AirPak.Controllers.Product
{
    public class ProductController : Controller
    {
        public async Task<IActionResult> Index(int id)
        {
            blProduct blProduct = new blProduct();
            BE.Product? p = blProduct.SearchById(id);

            blClick blClick = new blClick();
            await blClick.Create();  

            return View(p);
        }

    }
}



