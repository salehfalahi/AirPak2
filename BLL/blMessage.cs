using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class blMessage
    {
        public void Create(Message m)
        {
            daMessage daM=new daMessage();
            daM.Create(m);
        }
    }
}
