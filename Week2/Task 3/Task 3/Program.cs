using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_3
{
    class Program
    {
        //просто функция которая принтит пробелы
        public static void space(int level)
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write("       ");
            }
        }
        //сортирующяя функция которая будет вывдоить папки с файлами
        public static void show(DirectoryInfo dir, int level)
        {
            foreach (DirectoryInfo direc in dir.GetDirectories())
            {
                space(level);
                Console.WriteLine(direc.Name);
                show(direc, level + 1);
            }
            foreach (FileInfo fil in dir.GetFiles())
            {
                space(level);
                Console.WriteLine(fil.Name);
            }        
        }
        static void Main(string[] args)
        {
            DirectoryInfo direc = new DirectoryInfo("C:/Users/Санжар/Desktop/C#");
            show(direc, 0);
            Console.ReadKey();
        }
    }
}