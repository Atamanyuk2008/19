using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt19n2n1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = 1;
            int d = 4;


            for (int a = 1; a <= 5; a++)
            {
                int an = a1 + (a - 1) * d;
                Console.Write(an + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
