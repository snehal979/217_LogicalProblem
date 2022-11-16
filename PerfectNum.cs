using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class PerfectNum
    {
        public static void perfect_number()
        {
            Console.WriteLine("enter the min and max number");
            int min = Convert.ToInt32(Console.ReadLine()); // positive number
            int max = Convert.ToInt32(Console.ReadLine()); // positive number


            //number = sum of divisors excluding the number, it is called a Perfect Number.

            for (int num = min; num <= max; num++)
            {
                int sum = 0;
                for (int j = 1; j<num; j++)
                {
                    if (num%j == 0)
                    {
                        sum +=j;
                    }


                }
                if (sum == num)
                {
                    Console.WriteLine("the number is perfect number : " +num);
                }





            }



        }
    }
}
