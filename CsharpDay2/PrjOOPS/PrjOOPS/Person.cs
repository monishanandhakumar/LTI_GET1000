// Namespace -base class library
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjOOPS
{
    //default access specfier for variable is internal
    class Person
    {
        //variable --default access specfier for variable and method is private
        //Instances variable
        string name,city;
        int age;

        //methods or function
/*access specifier or modifier returntype methodname(paralist)
{
 code
}*/
        void  GetData()
        {
            Console.WriteLine( "Enter your name" );
            name = Console.ReadLine();
            Console.WriteLine("Enter your city");
            city= Console.ReadLine();
            
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32( Console.ReadLine());//Explicit type conversion
        }
        void PrintUserData()
        {
            Console.WriteLine("Name:{0} || City:{1} || Age:{2}",name,city,age);
        }
   static void Main()
        {
            Person p = new Person();
            p.city = "chennai"; //instance variable
            Console.WriteLine(p.city);
            p.GetData();
            p.PrintUserData();
            Console.Read();
        }

}
}
