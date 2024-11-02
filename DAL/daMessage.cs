using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class daMessage
    {
        AppDbContext appDbContext=new AppDbContext();

        public void Create(Message message)
        {
            appDbContext.Messages.Add(message);
            appDbContext.SaveChanges();
        } 
    }
}
