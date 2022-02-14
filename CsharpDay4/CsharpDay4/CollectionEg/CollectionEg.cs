using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_GenericsEg
{
    class CollectionEg
    {
        static void ArrayListEg()
        {
            ArrayList al = new ArrayList();
            al.Add(10); //boxing
            al.Add("Mango");
            al.Add(true);
            al.Add('j');
            al.Add(30.6f);

            Console.WriteLine("Capacity:{0}",al.Capacity);
            Console.WriteLine("count:{0}", al.Count);
            Console.WriteLine("Indexof:{0}",al.IndexOf('j'));

            for(int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }
            foreach (var arraylist in al) //unboxing
            {
                Console.WriteLine(arraylist);
            }
            al.Remove(true);

            Console.WriteLine("äfter removing");
            foreach (var arraylist in al)
            {
                Console.WriteLine(arraylist);
            }
        }//combination key and value
        static void HashtableEg()
        {
            Hashtable ht = new Hashtable();
            ht.Add(5, "Mango");
            ht.Add(3, "Apple");
            ht.Add(1, "Apple");
            ht.Add("G", "Grapes");

            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key+" "+de.Value);
            }

            Console.WriteLine(ht.Contains("e"));
        }
         
        static void SortedList()
        {
            SortedList sl = new SortedList();
            sl.Add(5, "Mango");
            sl.Add(3, "Apple");
            sl.Add(1, "Apple");
            foreach (DictionaryEntry de in sl)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }
        }

        static void StackEg()
        {
            Stack stack = new Stack();
            stack.Push(90);
            stack.Push("god");
            stack.Push(78.9f);
            Console.WriteLine("------------Stack----------");
            Console.WriteLine(stack.Pop()); //remove the element from stack
            foreach(var st in stack)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine(stack.Peek());//display the current element in stack
        }

       

        //queue  
        static void Main()
        {
            CollectionEg. ArrayListEg();
            HashtableEg();
            Console.WriteLine("SortedList");
            SortedList();
            StackEg();
        }

    }
}
