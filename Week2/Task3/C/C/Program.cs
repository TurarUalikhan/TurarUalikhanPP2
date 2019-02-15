using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace C
{
    class Program
    {
        static void WhiteSpace(int level)// метод для пробелов 
        {
            for(int i = 0; i< level * 4; i++)//умножить на 4 чтобы увеличить кол-во пробелов не меняя изначальное число
            {
                Console.Write(" ");
            }
        }
        static void print(string path, int level)//метод для выписывания всех папок и файлов
        {
            DirectoryInfo d = new DirectoryInfo(path);//все папки
            DirectoryInfo[] directoryInfos = d.GetDirectories();//для именно одной папки
            FileInfo[] fileInfos = d.GetFiles();//для файла 

            foreach(FileInfo f in fileInfos)//метод выдающий название файла и добавляет пробелы 
            {
                WhiteSpace(level);
                Console.WriteLine(f.Name);
            }
            foreach(DirectoryInfo dInfo in directoryInfos)//метод выдающий название папки и ее название 
            {
                WhiteSpace(level);//добавляет пробелы
                Console.WriteLine(dInfo.Name);
                print(dInfo.FullName, level + 1);//добавляет полностью весь пред путь, и увеличивающий кол-во пробелов 
            }

        }
        static void Main(string[] args)
        {
            string path = @"C:\Program Files (x86)\Intel";//путь 
            print(path, 0);//адрес пути и изначальное кол-во пробелов

        }
    }
}
