using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace D
{
    class Program
    {
        static void CCD(string path, string path1)//Метод для создание нового файла и копирования туда значения из пред файла
        {
            string FileName = "text.txt";//создание файла
            string newpath = Path.Combine(path, FileName);//объединение пути с названием
            string newpath1 = Path.Combine(path1, FileName);
            StreamWriter sw = new StreamWriter(newpath);
            sw.Write("asdasd");//запись нового текста к новому файлу
            sw.Close();
            File.Copy(newpath, path1);//копируем данные из newpath в path1
            File.Delete(newpath);//удаялем пред файл
        }
        static void Main(string[] args)
        {
            CCD(@"C:\Users\Turar\Desktop\path1", @"C: \Users\Turar\Desktop\path2");//указываем 2 пути
        }
    }
}
