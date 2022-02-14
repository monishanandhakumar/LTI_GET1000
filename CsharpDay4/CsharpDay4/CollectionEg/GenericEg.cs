using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_GenericsEg
{
    class GenericEg
    {
        static void ListEg()
        {
            List<string> book = new List<string>();
            book.Add("Java");
            book.Add("OS");
            book.Add("NW");
            book.Add("OOAD");

            foreach(var listbook in book)
            {
                Console.WriteLine("Book:{0}",listbook);
            }

            book.Insert(2, ".Net");
            Console.WriteLine("After Adding");
            foreach (var listbook in book)
            {
                Console.WriteLine("Book:{0}", listbook);
            }
            List<string> book1 = new List<string>();
            book1.Add("XXXX");
            book1.Add("YYYY");
            book.AddRange(book1); //adding onelist into another list
            Console.WriteLine("After adding author");
            foreach (var listbook in book)
            {
                Console.WriteLine("Book:{0}", listbook);
            }
        }
        static void DicionaryEg()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(10, "Anu");
            dt.Add(2, "Siva");
            dt.Add(30, "Hari");

            Console.WriteLine("-------------Dictionary-------------");
            foreach(KeyValuePair<int,string> kp in dt)
            {
                Console.WriteLine(kp.Key+" "+kp.Value);
            }
        }
        static void SortedListEg()
        {
           SortedList<int, string> st = new SortedList<int, string>();
            st.Add(10, "Anu");
            st.Add(2, "Siva");
            st.Add(30, "Hari");

            Console.WriteLine("-------------SortedList-------------");
            foreach (KeyValuePair<int, string> kp in st)
            {
                Console.WriteLine(kp.Key + " " + kp.Value);
            }
        }

        static void Main()
        {
           ListEg();
            DicionaryEg();
            SortedListEg();
            //stack and queue


        }
    }
}
