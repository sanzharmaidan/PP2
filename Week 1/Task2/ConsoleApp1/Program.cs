using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;
        public int year;

        public Student (string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public Student(int year)
        {
            this.year = year;
        }
        public void Plus()
        {
            year++;
        }
        
        public void show()
        {
            Console.WriteLine(name + " " + " " + year);
        }
    }
    class Program
    { 
        public static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[]s = a.Split();
            Student Studik = new Student(s[0], s[1]);
            Studik.year = int.Parse(s[2]);
            Studik.Plus();

        }
    }
}
