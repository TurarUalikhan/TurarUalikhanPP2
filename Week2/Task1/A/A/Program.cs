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
        static bool polindrome(string k) //создаем метод polindrome для проверки текста
        {
            int n = k.Length; 
            for(int i = 0; i < n;i++)
            {
                if(k[i] != k[n - i - 1]) //если не равен противоположному от себя числу то не полиндром(false)
                {
                    return false; 
                }
            }
            return true; 
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Turar\Desktop\text.txt"); //путь к файлу
            string k = sr.ReadToEnd();
            if (polindrome(k)) 
            {
                Console.WriteLine("YES"); //Если проходит то выдает "YES"
            }else
            {
                Console.WriteLine("NO"); //в другом случае "NO"
            }
            sr.Close();
        }
    }
}
