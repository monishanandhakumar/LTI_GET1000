using System;

namespace CodilityLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mark = { 10, 20, 30 };

            for(int i=0;i<mark.Length;i++)
            {
                Console.WriteLine(mark[i]);
            }

            int[][] arr = new int[2][]; //jagged array
            arr[0] = new int[] { 10, 20, 30 };
            arr[1] = new int[] { 100, 200, 300,600,700 };

            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr[i].Length;j++)
                {
                    Console.Write(arr[i][j]+ " ");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
