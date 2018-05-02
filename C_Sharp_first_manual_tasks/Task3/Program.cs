using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task.printFromAtoB(3, 7); 
        }
    }

    public class Task
    {
        public static void printFromAtoB(int a, int b)
        {
            for (int i = a; i < b+1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
