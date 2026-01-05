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
            var summary = BenchmarkRunner.Run<Testing>();


        }

    }
    public class Testing
    {
        static int Iterations = 10000;
        [Benchmark]
        public string UseString()
        {
            string value = "";

            for (int i = 0; i < Iterations; i++)
            {
                value += i.ToString();
                value += " ";
            }

            return value;
        }

        [Benchmark]
        public string UseStringBuilder()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < Iterations; i++)
            {
                builder.Append(i.ToString());
                builder.Append(" ");
            }

            return builder.ToString();
        }
    }
}
