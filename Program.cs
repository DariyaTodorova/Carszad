using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Opel", "Astra", "BM8906", 1986);
            Car car2 = new Car("BMW", "8", "CV8765", 2012);
            List<Car> carList = new List<Car>();

            car1.Print();
            car1.IsEco();
            car1.PrintMe();

            car2.Print();
            car2.IsEco();
            car2.PrintMe();
            Console.WriteLine();
            Console.WriteLine($"Cars are: {Car.Count}");
           
        }
    }
}
