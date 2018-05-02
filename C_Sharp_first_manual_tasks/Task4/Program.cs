using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string str = Console.ReadLine();
            char[] array;
            array = str.ToCharArray();
            Reverse(array);      
        }

        public static void Reverse(char[] arr)
        {
            Array.Reverse(arr);
            Console.WriteLine("Reversed number: ");
            Console.WriteLine(arr);
        }
    }
}
