using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class blClick
    {
        public async Task Create()
        {
            daClick C = new daClick();
            await C.Create();  // استفاده از await برای اجرای صحیح متد async
        }
    }
}
