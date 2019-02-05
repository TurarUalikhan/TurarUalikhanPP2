using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            string v = Console.ReadLine();
            int val = int.Parse(v);
            for (int i = 1; i <= val; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
