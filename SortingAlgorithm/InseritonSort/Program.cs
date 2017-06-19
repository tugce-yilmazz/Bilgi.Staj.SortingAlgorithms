using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InseritonSort;

namespace InseritonSort
{
    class Program
    {
        public static void Main()
        {
            int[] x = { 1, 5, 10, 2, 3, 15, 12, 7, 5, 4, 2, 1 };
            int j;
            int temp;
            for (int i = 1; i < x.Length; i++)
            {
                j = i - 1;

                while (j >= 0 && x[j] > x[j + 1])
                {
                    temp = x[j];
                    x[j] = x[j + 1];
                    x[j + 1] = temp;

                    j = j - 1;

                }
            }

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);

            }
            Console.ReadLine();
        }
    }
}
