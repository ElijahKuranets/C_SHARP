using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordOfTanks
{
    class Program
    {
        static int FindByModel(string model_, Tank[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i].Model == model_) ++count;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Random ran = new Random();
            Tank[] T34array = new Tank[5];
            Tank[] panterArray = new Tank[5];
            Tank[] winnersArray = new Tank[5];
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Состав   Боекомплект     Уровень брони   Маневренность");
            Console.WriteLine("----------------------------------------------------------");
            for (int i = 0; i < 5; ++i) T34array[i] = new Tank(ran.Next(0, 100), ran.Next(0, 100), ran.Next(0, 100), "T-34");
            for (int i = 0; i < 5; ++i) panterArray[i] = new Tank(ran.Next(0, 100), ran.Next(0, 100), ran.Next(0, 100), "Panther");
            for (int i = 0; i < 5; ++i)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Бой" + (i + 1) + "------------------------------------------------------");
                Console.WriteLine(T34array[i].ToString() + "\n" + panterArray[i].ToString());
                Console.WriteLine();
                winnersArray[i] = T34array[i] ^ panterArray[i];
            }
            for (int i = 0; i < 5; ++i)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Бой " + (i + 1) + " Panther vs. T-34 ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Победа " + winnersArray[i].Model + "\n");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------------------------");
            if (FindByModel("Panther", winnersArray) >= 3) Console.WriteLine("Победила команда Пантер");
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Победила команда Т-34");
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

