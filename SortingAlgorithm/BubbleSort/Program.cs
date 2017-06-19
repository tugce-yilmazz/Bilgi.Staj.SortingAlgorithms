using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    class Program
    {
        static int BubbleSort()
        {
            Console.Write("\nProgram for Ascending order of Numeric Values using BUBBLE SORT");
            Console.Write("\n\nEnter the total number of elements: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int[] numarray = new int[max];

            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                numarray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Before Sorting   : ");
            for (int k = 0; k < max; k++)
                Console.Write(numarray[k] + " ");
            Console.Write("\n");
            Console.ReadLine();

            for (int i = 1; i < max; i++)
            {
                for (int j = 0; j < max - i; j++)
                {
                    if (numarray[j] > numarray[j + 1])
                    {
                        int temp = numarray[j];
                        numarray[j] = numarray[j + 1];
                        numarray[j + 1] = temp;
                    }

                }

                Console.Write("After iteration " + i.ToString() + ": ");
                for (int k = 0; k < max; k++)
                    Console.Write(numarray[k] + " ");
                Console.Write("/*** " + (i + 1).ToString() + " biggest number(s) is(are) pushed to the end of the array ***/\n");
            }
            Console.ReadLine();

            Console.Write("\n\nThe numbers in ascending orders are given below:\n\n");
            for (int i = 0; i < max; i++)
            {
                Console.Write("Sorted [" + (i + 1).ToString() + "] element: ");
                Console.Write(numarray[i]);
                Console.Write("\n");
            }
            Console.ReadLine();
            return 0;
        }

        static void Main(string[] args)
        {
            BubbleSort();
            Console.ReadLine();
        }

    }
}

