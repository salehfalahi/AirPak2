using BE;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace DAL
{
    public class daViews
    {
        private readonly RequestDelegate _next;

        public daViews(RequestDelegate next)
        {
            _next = next;
        }

        //public async Task InvokeAsync(HttpContext context, AppDbContext _context)
        //{
        //    var today = DateTime.Today;

        //    var visit = await _context.Visits.FirstOrDefaultAsync(v => v.Date == today);

        //    if (visit == null)
        //    {
        //        visit = new Visit { Date = today, Count = 1 };
        //        _context.Visits.Add(visit);
        //    }
        //    else
        //    {
        //        visit.Count++;
        //    }

        //    await _context.SaveChangesAsync();

        //    await _next(context);
        //}
    }
}