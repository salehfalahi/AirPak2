using BE;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

public class ClickController : Controller
{


    //[HttpPost]
    //public async Task<IActionResult> RegisterClick()
    //{
    //    var click = new Click
    //    {
    //        ClickTime = DateTime.UtcNow
    //    };

    //    _context.Clicks.Add(click);
    //    await _context.SaveChangesAsync();

    //    return Ok();
    //}

    //[HttpGet]
    //public async Task<IActionResult> GetClicksToday()
    //{
    //    var startOfDay = DateTime.UtcNow.Date;
    //    var endOfDay = startOfDay.AddDays(1);

    //    var clickCount = await _context.Clicks
    //        .CountAsync(c => c.ClickTime >= startOfDay && c.ClickTime < endOfDay);

    //    return Ok(clickCount);
    //}
}
