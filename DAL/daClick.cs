using BE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class daClick
    {
        private static AppDbContext db = new AppDbContext();

        public async Task Create()
        {
            // ایجاد یک شیء جدید از Click
            var click = new Click
            {
                ClickTime = DateTime.Now
            };

            // اضافه کردن شیء به DbSet
            db.Clicks.Add(click);

            // ذخیره تغییرات در دیتابیس به صورت async
            await db.SaveChangesAsync();  // استفاده از SaveChangesAsync برای عملیات asynchronous
        }
    }
}

