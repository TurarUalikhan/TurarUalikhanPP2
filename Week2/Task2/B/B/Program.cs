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
        static bool prime(int n) //проверка на prime 
        {
            if (n == 1) //если 1 то false
            {
                return false;
            }
            for(int i = 2; i<n; i++) //если делится без остатка на любое другое число то false
            {

                if (n % i == 0) 
                {
                    return false;
                }
            }return true; //true в другом случае
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Turar\Desktop\input.txt"); //путь к файлу
            string s = sr.ReadToEnd(); 
            string[] arr = s.Split(); //массив с разделеными числами из файла
            sr.Close(); 

            StreamWriter sw = new StreamWriter(@"C:\Users\Turar\Desktop\output.txt"); //создаем папку(если нет) или меняем ее значение 
            string res = "";
            for(int i = 0; i < arr.Length; i++)
            {
                int num = int.Parse(arr[i]);
                if (prime(num)) //если num то res присваевает его значение и при след прайм числе он добавится к предыдущим
                {
                    res = res + num + ' '; 
                }
            }
            sw.Write(res);//выписываем все числа 
            sw.Close();
        }
    }
}
