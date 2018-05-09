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
//ВАРИАНТ ВРУЧНУЮ
//int[] numbers = { -4, -3, -2, -1,0, 1, 2, 3, 4 };
//int n = numbers.Length; // длина массива
//int k = n / 2;          // середина массива
//int temp;               // вспомогательный элемент для обмена значениями
//for(int i=0; i<k; i++)
//{
//    temp = numbers[i];
//    numbers[i] = numbers[n - i - 1];
//    numbers[n - i - 1] = temp;
//}
//foreach(int i in numbers)
//{
//    Console.Write($"{i} \t");
//}