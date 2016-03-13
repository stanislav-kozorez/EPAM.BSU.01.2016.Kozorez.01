using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[5][] {new int[] {8, 4, 7, 10, 9, 5, 20, }, null, new int[] { 1, 7, 3 }, null, new int[] { 5, 7, 10, 7 }};
            int[][] arr2 = new int[arr.Length][];

            Console.WriteLine();
            Console.WriteLine("Logic Pow: {0} ", Task1.Root(8, 3));
            Console.WriteLine("Math Pow: {0} ", Math.Pow(6, 1/2.0));
           
            Console.WriteLine(Environment.NewLine + "Initial array:");
            arr.CopyTo(arr2, 0);
            PrintArray(arr2);

            Console.WriteLine("Sorted by max row sum(ascendent):");
            arr.CopyTo(arr2, 0); 
            Task2.SortByRowSum(arr2, SortOrder.Ascendent);
            PrintArray(arr2);

            Console.WriteLine("Sorted by max row sum(descendent):");
            arr.CopyTo(arr2, 0);
            Task2.SortByRowSum(arr2, SortOrder.Descendent);
            PrintArray(arr2);

            Console.WriteLine("Sorted by max row element(ascendent):");
            arr.CopyTo(arr2, 0);
            Task2.SortByMaxRowElement(arr2, SortOrder.Ascendent);
            PrintArray(arr2);

            Console.WriteLine("Sorted by max row element(descendent):");
            arr.CopyTo(arr2, 0);
            Task2.SortByMaxRowElement(arr2, SortOrder.Descendent);
            PrintArray(arr2);

            Console.WriteLine("Sorted by min row element(ascendent):");
            arr.CopyTo(arr2, 0);
            Task2.SortByMinRowElement(arr2, SortOrder.Ascendent);
            PrintArray(arr2);

            Console.WriteLine("Sorted by min row element(descendent):");
            arr.CopyTo(arr2, 0);
            Task2.SortByMinRowElement(arr2, SortOrder.Descendent);
            PrintArray(arr2);

            Console.ReadKey();
        }

        static void PrintArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                    Console.Write("null ");
                else
                {
                    for (int j = 0; j < arr[i].Length; j++)
                        Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
