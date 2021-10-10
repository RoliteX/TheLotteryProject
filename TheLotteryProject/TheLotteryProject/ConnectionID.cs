using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLotteryProject
{
    class ConnectionID
    {
        public string Address = System.IO.File.ReadAllText(@"C:\TheLotteryProject.txt");
    }
}
