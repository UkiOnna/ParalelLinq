using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelLink
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i);

            }
            numbers.AsParallel().Where(number => number % 2 == 0).ForAll(number => Console.WriteLine("Поток: "+Thread.CurrentThread.ManagedThreadId + " " + number));




        }

    }
}
