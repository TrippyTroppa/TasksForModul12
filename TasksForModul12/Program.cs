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
           
        }

        static int SearchIndex( int[] array, int element)
        {
            int index;
            for (index = 0; index < array.Length; index++)
            {
                if (array[index] > element)
                    return index;
            }
            return index;
        }
    }
}