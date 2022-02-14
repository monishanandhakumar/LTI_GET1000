using System;
using System.Linq;

namespace LinqEg
{
    /*
         * from<range variable> in <Ienumerable<T> or IQuerable<T> Collection>
         * Standard query or lambda expresion
         * <select  or group by operator> <result>
         */
    class LinqUsingObjects
    {
        //datasource
        string[] books = { "English", "java", "Cloud computing", "Grid computing", "Devops" };
        int[] marks = { 78, 90, 67, 89, 77, 56 };

    internal    void  string_intArray()
        {
            //Query syntax
            //fetching all the books 
            //select * from books

            var res = from br in books
                      select br;
            foreach(var bookname in res)
            {
                Console.WriteLine(bookname);
            }

            //fetch the book contains 'computing'

            var res1 = from br in books
                       where br.Contains("computing")
                       select br;
            Console.WriteLine("----------------------------");
            Console.WriteLine( "fetch the book contains 'computing'");
            foreach (var bookname in res1)
            {
                Console.WriteLine(bookname);
            }

            //Relational operator,Aggregate function
            Console.WriteLine("MinMarks:{0}", marks.Min());
            Console.WriteLine("MaxMarks:{0}", marks.Max());
            //display the no of students btw 80 to 90
            int noofstudents = (from mr in marks
                                where mr < 90 && mr > 80
                                select mr).Count();

            Console.WriteLine("no of students btw 80 and 90:{0}",noofstudents);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            LinqUsingObjects linqEg = new LinqUsingObjects();
            linqEg.string_intArray();
        }
    }
}
