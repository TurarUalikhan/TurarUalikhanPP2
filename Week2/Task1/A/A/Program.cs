using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace A
{
    class Program
    {
        static bool polindrome(string k) 
        {
            int n = k.Length; 
            for(int i = 0; i < n;i++)
            {
                if(k[i] != k[n - i - 1]) 
                {
                    return false; 
                }
            }
            return true; 
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Turar\Desktop\text.txt"); 
            string k = sr.ReadToEnd();
            if (polindrome(k)) 
            {
                Console.WriteLine("YES"); 
            }else
            {
                Console.WriteLine("NO"); 
            }
        }
    }
}
