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

        static void Condition()
        {
            Console.WriteLine("Enter your age");
            int age = Int32.Parse(Console.ReadLine());

            if (age > 13)
            {
                Console.WriteLine("Registration successful");
            }
            else
            {
                Console.WriteLine("If your age under 14, you can not be registered");
            }
        }
    }
}
