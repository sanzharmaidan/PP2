using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK22
{
    //создаем класс где имя айди и год обучения
    public class me
    {
        public string name = "Sanzhar";
        public string idishka = "18BD110281";
        public int year = 1;
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            me s1 = new me();
            s1.year++; //просто прибавляем к нашему году обучения +1
            Console.WriteLine(s1.name + " " + s1.idishka + " " + s1.year);//выводим
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
