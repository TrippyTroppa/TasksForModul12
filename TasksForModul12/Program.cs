using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void FillArray()
        {
            Console.WriteLine("Enter the number of array elements...");
            int count = Convert.ToInt32(Console.ReadLine());
            var array = new string [count];

            for (int i = 0; i < count; i++)
            {
                array [i] = Console.ReadLine();
            }

        }
    }
}
