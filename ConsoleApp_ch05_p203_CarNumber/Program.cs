using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1017p203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetCarNumber("12가3456");

            Console.WriteLine(car.GetCarNumber());
            Console.ReadLine();
        }
    }
}
