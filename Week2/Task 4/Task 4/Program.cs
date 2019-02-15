using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 переменные которые определяют пути к файлам: с path копируем и удаляем, в path1 копируем
            string path = "C:/Users/Санжар/Desktop/C#/PP2/copy/copy.txt";
            string path1 = "C:/Users/Санжар/Desktop/C#/PP2/paste/";
            FileInfo fi = new FileInfo(path);
            //копируем из path в path1
            fi.CopyTo(path1 + "/copycopy.txt", true);
            //удаляем из path
           fi.Delete();
        }
    }
}
