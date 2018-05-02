using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());   
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int count_A = 0;
            int count_B = 0;
            while(A >= C)
            {
                A -= C;
                while(B >= C)
                {
                    ++count_B;
                    B -= C;
                }
                count_A += count_B;
            }
            Console.WriteLine(count_A);
        }
    }
}
