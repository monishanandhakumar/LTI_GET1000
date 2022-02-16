using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjOOPS
{
    class Student
    {
        public string sname { get; set; }

        public string dept { get; set; }

        //static variable
        internal static string collegename ;

        //static constructor
       static Student()
        {
            Console.WriteLine("static Constructor");
            collegename = "MIT";
        }
        internal Student(string sname,string dept)
        {
            Console.WriteLine("Constructor");
            //this refers to current class instance variable
            this.sname = sname;
            this.dept = dept;
        }
        internal void PrintData()
        {
            Console.WriteLine("Name:{0} || Dept:{1} || CollegeName:{2}",sname,dept,collegename);
        }
       
        internal static float studentAverage(int total, int noofsubjects)
        {
            float average = total / noofsubjects;
            Math.Floor(78.90);

            return average;
        }

    }
    class StaticEg
    {
        public static void Main()
        {
          /*  Student student = new Student("Anu","CSE");
            student.PrintData();
            Student student1 = new Student("Banu", "EEE");
            student1.PrintData();
            Student student2 = new Student("Srini", "Mech");
            student2.PrintData();*/

          Student.studentAverage(500,5);

            //Array of objects
            Console.WriteLine("Enter the no of students");
            int n = Convert.ToInt32(Console.ReadLine());
            string stuname, studept;
            Student[] students = new Student[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter name");
                stuname = Console.ReadLine();
                Console.WriteLine("Enter dept");
                studept = Console.ReadLine();
                students[i] = new Student(stuname, studept);
            }
            for (int i = 0; i < n; i++)
            {
                students[i].PrintData();
            }

            Console.Read();
        }
    }
}
