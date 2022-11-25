using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class FibonacciSeries
    {
        public static void Fibonacci_Series()
        {
            //vaiable
            int fib1, fib2, fib3;
            fib1 = 0;
            fib2 = 1;

            Console.WriteLine("Enter the n th fibonacci number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("fibonacci series");

            Console.WriteLine(fib1);
            Console.WriteLine(fib2);
            // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 14
            // fib1,fib2,fib3,fib4,_________
            // Fn = Fn-1 + Fn-2


            for (int i = 0; i < num; i++)
            {
                fib3 = fib2 + fib1;
                Console.WriteLine(fib3);
                fib1=fib2;
                fib2=fib3;

            }
        }
    }
}
