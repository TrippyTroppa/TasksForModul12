using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TasksForModul12
{
    class Program
    {
        static void Main(string[] args)
        {
            UseString(70000);
            Console.WriteLine("Ready to switch");
            Console.ReadKey();

            UseStringBuilder(70000);
            Console.ReadKey();
        }

        static string UseString(int n)
        {
            string value = "";

            for (int i = 0; i < n; i++)
            {
                value += i.ToString();
                value += " ";
            }

            return value;
        }

        static string UseStringBuilder(int n)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                builder.Append(i.ToString());
                builder.Append(" ");
            }

            return builder.ToString();
        }
    }
}
