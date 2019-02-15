using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        //prime проверка
        public static bool p(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("number1.txt");
            String s = sr.ReadToEnd();
            String[] arr = s.Split();
            int[] n = new int[arr.Length];
            sr.Close();

            //парсим в int
            for (int i = 0; i < arr.Length; i++)
            {
                n[i] = int.Parse(arr[i]);
            }

            //txt файл с простыми чилсами
            StreamWriter sw = new StreamWriter("primes.txt");
            for (int i = 0; i < n.Length; i++)
            {
                if (p(n[i]) == true) sw.Write(n[i] + " ");
            }
            sw.Close();
            Console.ReadKey();

        }

    }

}
