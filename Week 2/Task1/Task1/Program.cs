using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void f1()
        {
            StreamReader st = new StreamReader("C:/Users/Санжар/Desktop/input.txt");
            string s = st.ReadToEnd();
            string[] t = s.Split();
            int n = t.Length;
            for (int i = 0; i < n; i++)
            {
                if (t[i] != t[n - i - 1])
                {
                    Console.WriteLine("NO");
                    return;

                }
                st.Close();
                Console.WriteLine("YES");
                Console.ReadKey();
            }

        }
        static void Main(string[] args)
        {
            f1(); Console.ReadKey();
        }

    }
}

