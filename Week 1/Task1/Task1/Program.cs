using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            string[] s = Console.ReadLine().Split();

            List<int> v = new List<int>();
            int cnt = 0;


            for (int i = 0; i < x; i++)
            {
                int a;
                a = int.Parse(s[i]);
                if (a == 1)
                    continue;
                int r = 1;

                for(int k = 2; k<=Math.Sqrt(a); k++)
                {
                    if (a % k == 0)
                    {
                        r = 0;
                        break;
                    }

                }
                if(r == 1)
                {
                    v.Add(a);
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
                for(int i = 0; i<v.Count; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
