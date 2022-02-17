using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLesson
{
    class Lesson2_Arrays
    {

        static void Negativetemperature(int[] temperture)
        {
            int n = temperture.Length;
            int days = 0;
            foreach (int t in temperture)
            {
                if (t < 0)
                {
                    days = days + 1;
                }
            }
            Console.WriteLine("No of days with negative tem:{0}", days);
        }

        static void ArrayReverse()
        {
            int[] arr = { 90, 56, 89, 23, 67 };
            Array.Reverse(arr);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            Array.Sort(arr);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int s = 0;
            for (int i = 0; i < A.Length; i++)
            {
                s ^= A[i];

            }
            return s;
        }



        static void Main()
        {
            int[] tem = { -2, 89, 90, -5, -7 };
          //  Negativetemperature(tem);
            Console.WriteLine("------------------");
          //  ArrayReverse();
            int[] A = { 8, 9, 6, 8, 9 };
            Console.WriteLine(solution(A)); 
        }
    }
}

