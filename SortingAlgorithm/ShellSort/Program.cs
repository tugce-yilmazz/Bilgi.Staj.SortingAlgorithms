using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, -4, 11, 0, 17, 22, 69, 55, 5 };
            int n;

            n = arr.Length;
            Console.WriteLine("Original Array Elements :");
            show_array_elements(arr);
            
            shellSort(arr, n);
            Console.WriteLine("\nSorted Array Elements :");
            show_array_elements(arr);
            Console.ReadLine();
        }

        static void shellSort(int[] arr, int array_size)
        {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
                
            }
        }

        static void show_array_elements(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write(element + " ");
                Console.Write("\n");
            }
            
            Console.ReadLine();

        }
    }
}
