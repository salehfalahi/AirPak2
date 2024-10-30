using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class blProduct
    {
        public async Task<List<Product>> ReadAsync()
        {
            daProduct Product = new daProduct();
            return await Product.ReadAsync();
        }
        public Product? SearchById(int id)
        {
            DAL.daProduct dah = new daProduct();
            return dah.SearchById(id);
        }
    }
}
