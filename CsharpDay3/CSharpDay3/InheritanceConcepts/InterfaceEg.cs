using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcepts
{
    interface INormalCalclator
    {
        string calculatorname { get; set; }
        int Add(int a, int b); //public abstract
        int Sub(int a, int b);
    }

    class Pixel:INormalCalclator,IScientificcalculator
    {
        public string isbn { get; set; }
       public string calculatorname { get; set; }
         int INormalCalclator.Add(int x,int y)
        {
            calculatorname = "Normalcalculator";
            Console.WriteLine(calculatorname);
            return x + y;
        }
        public int Sub(int x,int y)
        {
            return x - y;
        }
         int IScientificcalculator.Add(int x, int y)
        {
            calculatorname = "scientificcalculator";
            Console.WriteLine(calculatorname);
            return x + y;
        }

    }
    class InterfaceEg
    {
        static void Main()
        {
            INormalCalclator normalCalclator = new Pixel();
            int c=normalCalclator.Add(9,8);
            Console.WriteLine("Normalcal add id:{0}",c);
            Console.WriteLine("sub method :{0}",normalCalclator.Sub(7,5));
            IScientificcalculator scientificcalculator= new Pixel();
            Console.WriteLine("scientific add is:{0}",scientificcalculator.Add(10,20));
        }
    }
}
