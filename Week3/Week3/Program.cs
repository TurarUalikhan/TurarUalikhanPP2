using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace example
{
    class Program
    {
        static void print(DirectoryInfo d, int cursor)//установка цветов
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();//удаляем все при обновлении
            FileSystemInfo[] fsis = d.GetFileSystemInfos();
            for (int i = 0; i < fsis.Length; i++)
            {
                if (fsis[i].GetType() == typeof(FileInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;//если файл то желтый
                }
                if (fsis[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;//если папка то белая
                }

                if (i == cursor)
                {
                    Console.BackgroundColor = ConsoleColor.Red;//если выделено курсором то красная 
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;//фон черный
                }
                Console.WriteLine(i+1+ "."+' '+ fsis[i].Name);//переделываем все в строку
            }
        }


        static void Main(string[] args)
        {

            DirectoryInfo d = new DirectoryInfo(@"C: \Users\Turar\Desktop");//путь к файлу
            int cursor = 0;
            int n = d.GetFileSystemInfos().Length;
            print(d, cursor);
            while (true)//горячие клавиши в цикле
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                FileSystemInfo[] fsis = d.GetFileSystemInfos();
                if (keyInfo.Key == ConsoleKey.UpArrow)//при нажати стрелки 
                {
                    cursor--;//курсор уменьшается то есть идет к пред элементу
                    if (cursor == -1)//если курсор дойдет до верха то его перекидываем вниз
                    {
                        cursor = n - 1;
                    }
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)//нижняя стрелка
                {
                    cursor++;//курсор увеличиваем то есть идет к след элементу
                    if (cursor == n)//если в самом низу то перекидываем на верх
                    {
                        cursor = 0;
                    }
                }
                if (keyInfo.Key == ConsoleKey.Enter)//ввод
                {
                    if (fsis[cursor].GetType() == typeof(DirectoryInfo))//если это папка то заходит в нее
                    {
                        d = new DirectoryInfo(fsis[cursor].FullName);
                        cursor = 0;
                        n = d.GetFileSystemInfos().Length;
                    }
                    if (fsis[cursor].GetType() == typeof(FileInfo))//если файл то показывает данные файла
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        StreamReader sr = new StreamReader(fsis[cursor].FullName);
                        Console.WriteLine(sr.ReadToEnd());
                        Console.ReadKey();
                    }


                }
                if (keyInfo.Key == ConsoleKey.Backspace)//назад
                {
                    if (d.Parent != null)//если не равно нулю т.е. если эта папка находится в другой папке то цикл идет
                    {
                        d = d.Parent;
                        cursor = 0;
                        n = d.GetFileSystemInfos().Length;
                    }
                    else//если нет то программа заканчивается
                    {
                        break;
                    }
                }
                if (keyInfo.Key == ConsoleKey.Delete)//удалить
                {
                    if (fsis[cursor].GetType() == typeof(DirectoryInfo))//если папка
                    {
                        DirectoryInfo temp = new DirectoryInfo(fsis[cursor].FullName);
                        if (temp.GetFileSystemInfos().Length == 0)
                        {
                            Directory.Delete(temp.FullName);//удаляем без спроса если папка пустая
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.WriteLine("If you want to delete then press Y if not press any other key");//спрашиваем если внутри есть что то
                            ConsoleKeyInfo k = Console.ReadKey();
                            if (k.Key == ConsoleKey.Y)//удаляем если нажали Y
                            {
                                Directory.Delete(temp.FullName, true);
                            }
                            else//любая другая клавиша то продолжает программу
                            {
                                continue;
                            }
                        }

                    }
                    if (fsis[cursor].GetType() == typeof(FileInfo))//для удаления файла
                    {
                        File.Delete(fsis[cursor].FullName);
                    }
                }
                if (keyInfo.Key == ConsoleKey.R)//для изменения навания нажмите R
                {
                    if (fsis[cursor].GetType() == typeof(DirectoryInfo))//создаем новую папку с заданым именем и перекидываем туда все файлы а старую удалаяем
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        string s = Console.ReadLine();
                        string fileN = fsis[cursor].Name;
                        string fullN = fsis[cursor].FullName;
                        int len = fileN.Length;
                        string newName = "";
                        for (int i = 0; i < fullN.Length - len; i++)
                        {
                            newName = newName + fullN[i];
                        }
                        newName = newName + s;
                        Directory.Move(fullN, newName);
                    }
                    if (fsis[cursor].GetType() == typeof(FileInfo))//тоже делаем для файла
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        string s = Console.ReadLine();
                        string fileN = fsis[cursor].Name;
                        string fullN = fsis[cursor].FullName;
                        int len = fileN.Length;
                        string newName = "";
                        for (int i = 0; i < fullN.Length - len; i++)
                        {
                            newName = newName + fullN[i];
                        }
                        newName = newName + s;
                        File.Move(fullN, newName);
                    }
                }
                Console.Clear();
                print(d, cursor);

            }
        }
    }
}
