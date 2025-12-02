using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TasksForModul12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] array = { 2, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int value = 2;

            int result = BinarySearch(value, array, 0, array.Length - 1);

            if (result != -1)
                Console.WriteLine($"Элемент {value} найден на позиции {result}");
            else
                Console.WriteLine($"Элемент {value} не найден в массиве");
        }

        static int BinarySearch(int value, int[] array, int left, int right)
        {
            while (left <= right)
            {
                var middle = (left + right) / 2;
                var midElement = array[middle];

                if (midElement == value)
                    return middle;
                else if (value > midElement)
                {
                    left = middle + 1;  
                }
                else
                {
                    right = middle - 1;
                }
            }
            return -1;
        }
    }
}