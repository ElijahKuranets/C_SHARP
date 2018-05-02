using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Demo
{
    class VehicleComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Vehicle c1 = x as Vehicle;
            Vehicle c2 = y as Vehicle;

            return c1.Price.CompareTo(c2.Price);
        }
    }
}
