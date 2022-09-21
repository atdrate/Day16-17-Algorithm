using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProblem16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number\n1.Anagram program\n2.Binary search\n3.BubbleSort\n4.Insertion sort\n5.Merge Sort\n6.AnagramOR not\n7.prime number between 0-1000\n8.Prime Number Which Is Anagram and Palindrome");
            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Anagram.anagram();
                    break;
                case 2:
                    BinarySearchWord.binarysearch();
                    break;
                case 3:
                    BubbleSort.Bubblesort();
                    break;
                case 4:
                    InsertionSort.Insert();
                    break;
                case 5:
                    MergeSort mergeSort = new MergeSort();
                    mergeSort.Merging();

                       break;
                case 6:
                    AnagramDetection.Anagramedtection();
                    break;
                case 7:
                    PrimeNumber.PrimeNumbersInRange();
                    break;
                case 8:
                    PrimeNoAnagramPolydrome.PrimeNumbers();
                    break;

            }
        }
    }
}
