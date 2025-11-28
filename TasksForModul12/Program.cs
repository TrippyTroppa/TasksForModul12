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

        static void Algoritm()
        {
            Console.WriteLine("Enter your name..");
            string name = Console.ReadLine();
            string greetings = $"Hello, {name}";
            Console.WriteLine(greetings);
            return;
        }
    }
}
