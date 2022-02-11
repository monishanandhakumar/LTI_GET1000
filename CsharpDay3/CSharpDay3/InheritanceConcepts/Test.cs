using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcepts
{
    class Test
    {
        //constant and read-only

     public   const string id = "J001";
        public float pi = 3.1f;

        Test()
        {
            pi = 3.14f; //read-only
        }
                                                 //optional parameter
      static  int Total(int m1,int m2,int m3,int m4,int assignmentmark=10 )
        {
            return m1 + m2 + m3 + m4+ assignmentmark;
        }
        
        static void Main()
        {
          //  id = "hj001";  //constant value cant be changed

            //boxing --converting value type to reference type 
            int num = 10; //value type
            object s = num;

            //Unboxing--Converting reference type to value type
            float f = (float)s;

            //var implicit type variable

            var city = "chennai"; //compile time variable
          //  city = 10; //error
            //dynamic --run time 
            dynamic a = 10;
            a = "hi";
            a = 90.78f;
                                         //named parameter   
            Console.WriteLine(Test.Total(m1: 90, m2: 78, 67, 56)); 
           


        }
    }
}
