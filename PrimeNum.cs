using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class PrimeNum
    {
        public static void Prime_Number()
        {
            Console.WriteLine("enter the range between");
            //int i = Convert.ToInt32(Console.ReadLine());
            int min = Convert.ToInt32(Console.ReadLine());
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("prime number betwwen {0} and {1}", min, max);

            for (int i = min; i <= max; i++)
            {

                int prime = 0;
                for (int j = 1; j<=i; j++) // if only input number then i replace by num variable
                {
                    if (i % j == 0)
                    {
                        prime++;
                    }
                }
                if (prime == 2)
                {
                    Console.WriteLine("prime number" +i);
                }
                else
                {
                    Console.WriteLine("not prime");
                }
            }





        }
    }
}

