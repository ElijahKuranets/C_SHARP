using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail
{
    class Logger : Ilogger
    {
        public void WriteError(string message)
        {
            Console.WriteLine("Error:"+ message);
        }

        public void WriteInfo(string message)
        {
            Console.WriteLine("Info" + message);
        }
    }
}
