using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLesson
{
    class Lesson1_Iteration
    {
      public  void Examples()
        {
            for(int i=0;i<100;i++)
            {
                Console.WriteLine(i);
            }

        }
        //factorial
        public static void factorialEg(int n)
        {
            int factorial=1;
            for(int i=1;i<=n;i++)
            {
                factorial = factorial * i;
                Console.Write(factorial);
                Console.Write(" ");
            }
            Console.WriteLine("---------------");
         }

        static void PrintInvertedTriangle(int n)
        {
            for(int i=n;i>0;i--)
            {
                for(int j=0;j<(n-i);j++)
                {
                    Console.Write(" ");
                }
                for(int j=0;j<(2*i-1);j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }

        static void FibanocciEg(int n)
        {
            int a = 0, b = 1, c;
            while(a<=n)
            {
                Console.WriteLine(a); //0
                c = a + b; //0+1 c=1
                a = b; //a =1
                b = c;//b=1
            }
        }

        static void Days()
        {
            string[] days = { "Monday", "tuesday", "Wednesday" };

            for(int i=0;i<days.Length;i++)
            {
                Console.WriteLine(days[i]);
            }

            foreach(var i in days)
            {
                Console.WriteLine(i);
            }
        }

        static void SetEg()
        {
            Dictionary<string, string> dt = new Dictionary<string, string>();
            dt.Add("Mon", "Monday");
            dt.Add("Tue", "Tuesday");
            dt.Add("Wed", "Wednesday");

            foreach(KeyValuePair<string,string> kp in dt)
                Console.WriteLine(kp.Key+" stands for   " +kp.Value);
        }

        //Binary Gap
        public int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string binarystring = Convert.ToString(N, 2);
            string[] subZeroes = binarystring.Split('1');
            int maxCount = 0;
            for (int i = 1; i < (subZeroes.Length - 1); i++)
            {
                if (subZeroes[i].Length > maxCount)
                {
                    maxCount = subZeroes[i].Length;
                }
            }
            return maxCount;
        }
        static void Main()
        {
            //factorialEg(5);
            Console.WriteLine("---------------------------");
            //PrintInvertedTriangle(4);

            FibanocciEg(5);

            SetEg();
        }

    }
}
