using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcepts
{
    class Sample<T> //generic class
    {
        int m = 89; float m1 = 89.6f;
       public T mark1;
       public T mark2;
        internal void Add<T>(T x,T y)  //generic method
        {
            if(x.Equals(y))
            Console.WriteLine(x+ " "+y);
            else
                Console.WriteLine("Not equal");
        }

        internal void Test()
        {
            if (mark1 !=null & mark2 !=null)
                Console.WriteLine(mark1+ " "+mark2);
        }
        
    }
    class GenericsConcept
    {
        static void Main()
        {
            Sample<int> sample = new Sample<int>();
            sample.mark1 = 90;

            Sample<float> sample1 = new Sample<float>();
            sample1.mark1 = 89.99f;
            sample.Add<int>(8, 8);
            sample.Add<string>("hi", "all");
        }
    }
}
