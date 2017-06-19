﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] ar = { 5, 3, 7, 2 };
            int n = ar.Length;
            for (int x = 0; x < n; x++)
            {
                int min_index = x;
                for (int y = x; y < n; y++)
                {
                    if (ar[min_index] > ar[y])
                    {
                        min_index = y;
                    }
                }
               
                int temp = ar[x];
                ar[x] = ar[min_index];
                ar[min_index] = temp;
            }
           
            Console.WriteLine("sort array in ascending order by using selection sort");

            foreach (int i in ar)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}