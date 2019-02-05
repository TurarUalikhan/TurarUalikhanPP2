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
            int[] arr = new int[int.Parse(line1) * 2];
            int cnt = -1;
            for(int i = 0; i< parts.Length; i++)
            {
                cnt++;
                arr[cnt] = int.Parse(parts[i]);
                cnt++;
                arr[cnt] = int.Parse(parts[i]);
                
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(' ');
            }
        }

        
    }
}
