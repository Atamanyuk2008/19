using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt16n3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int q = 0; q < 16; q++)
            {
                Console.Write("#");
            }
            for (int e = 0; e < 16 - 2; e++)
            {
                Console.Write("#");
                for (int j = 0; j < 16 - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("#");
            }
            for (int d = 0; d < 16; ds++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
