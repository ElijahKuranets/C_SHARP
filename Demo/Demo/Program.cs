using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicle = new Vehicle[]
            {
                new Vehicle() {Id = 1, Name = "Mazda", Price = 15000 },
                 new Vehicle() {Id = 2, Name = "Lamborgini", Price = 150000 },
                  new Vehicle() {Id = 3, Name = "Vaz", Price = 150 },
              //  null
            };

            Console.WriteLine(String.Join(" ", vehicle.ToList()));
            Array.Sort(vehicle, new VehicleComparer());
            Console.WriteLine(String.Join(" ", vehicle.ToList()));

            Console.WriteLine(vehicle.GetHashCode());

            Console.Read();
        }
    }
}
