using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch();
            Console.ReadLine();
        }

        private static void BinarySearch()
        {
            int searchItem = 64;
            var array = new int[] { 12, 19, 23, 27, 43, 49, 56, 58, 64, 76, 83, 89, 95 };
            int beg = 0;
            int end = array.Length;
            int index = -1;

            while (beg <= end)
            {
                int mid = (beg + end) / 2;
                if (array[mid] == searchItem)
                {
                    index = mid;
                    break;
                }
                else
                {
                    if (searchItem < array[mid])
                    {
                        end = mid - 1;
                    }
                    else if (searchItem > array[mid])
                    {
                        beg = mid + 1;
                    }
                }
            }

            Console.WriteLine("In Binary Search given no. is present at index = " + index.ToString());

        }

    }
}
