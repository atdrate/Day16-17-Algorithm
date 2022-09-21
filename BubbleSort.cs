using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProblem16
{
    internal class BubbleSort
    {
        public static void Bubblesort()
        {
            int[] arr = { 76, 35, 45, 38, 53 };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        Console.WriteLine("Sorted:");
                        foreach (int p in arr)
                            Console.WriteLine(p + " ");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
