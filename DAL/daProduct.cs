using BE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class daProduct
    {
        private static AppDbContext db = new AppDbContext();
        public async Task<List<Product>> ReadAsync()
        {
            return await db.Products.ToListAsync();
        }
        public Product? SearchById(int Id)
        {
            var q = from i in db.Products where Id == i.Id select i;

            return q.SingleOrDefault();
        }
    }
}
