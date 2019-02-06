using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace B
{
    class Program
    {
        static bool prime(int n) 
        {
            if (n == 1) 
            {
                return false;
            }
            for(int i = 2; i<n; i++) 
            {

                if (n % i == 0) 
                {
                    return false;
                }
            }return true; 
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Turar\Desktop\input.txt"); 
            string s = sr.ReadToEnd(); 
            string[] arr = s.Split(); 
            sr.Close(); 

            StreamWriter sw = new StreamWriter(@"C:\Users\Turar\Desktop\output.txt"); 
            string res = "";
            for(int i = 0; i < arr.Length; i++)
            {
                int num = int.Parse(arr[i]);
                if (prime(num)) 
                {
                    res = res + num + ' '; 
                }
            }
            sw.Write(res);
            sw.Close();
        }
    }
}
