using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail
{
    public interface Ilogger
    {
        void WriteError(string message);
        void WriteInfo(string message);
    }
}
