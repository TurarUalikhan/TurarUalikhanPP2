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
            
            for (int i =0; i < val; i++) 
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("[*]"); 
                }
                Console.WriteLine(); 
            }
        }
    }
}
