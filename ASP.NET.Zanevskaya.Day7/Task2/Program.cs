using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Library;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciNumbers.GetFibbonacciNumbers(10);

            //for (int i = 0; i < 4; i++)
            //{
            //    IEnumerable<int> f = FibonacciNumbers.GetFibbonacciNumbers(5);
            //    Console.WriteLine();
            //}
        }
    }
}
