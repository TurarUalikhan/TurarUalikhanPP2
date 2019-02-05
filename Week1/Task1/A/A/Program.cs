﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        static bool IsPrime(int n)
        {
            if (n == 1) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;

        }
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int s = int.Parse(n);
            string k = Console.ReadLine();
            string[] arr = k.Split();

            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                int num = int.Parse(arr[i]);
                if (IsPrime(num))
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < arr.Length; i++)
            {

                int num = int.Parse(arr[i]);
                if (IsPrime(num))
                {
                    Console.Write(num);
                    Console.Write(' ');
                }
            }
        }
    }
}
