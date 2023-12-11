using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_p189
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;

            bool state = true;
            while (state)
            {
                Console.Clear();
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("^_@");
                        x++;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine();
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine();
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine();
                        break;
                    case ConsoleKey.X:
                        state = false;
                        break;
               }
            }
        }
    }
}
