using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//создаем двумерный массив
            for(int i=0; i < n; i++)
            {
                for(int j=0; j<=i; j++)//делаем звездочки по количеству строк
                {           
                        Console.WriteLine("[*]");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
