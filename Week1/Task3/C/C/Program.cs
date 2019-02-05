using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            string[] parts = line2.Split(new char[] { ' ' });
            Console.WriteLine(parts.Length);
            for (int i = 0; i < parts.Length; ++i)
            {
                Console.Write(parts[i]);
                Console.Write(" ");
                Console.Write(parts[i]);
                Console.Write(" ");
            }
        }
    }
}
