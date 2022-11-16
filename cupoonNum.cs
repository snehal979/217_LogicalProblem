using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class cupoonNum
    {
        public static void Coupon_Numbers()
        {
            // random number to gertrated for coupon

            Console.WriteLine("how many coupon number you required ?");
            int total_number_cupon = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("genreted coupon number");



            for (int i = 0; i < total_number_cupon; i++)
            {
                Random number = new Random();
                int cuopon = number.Next(10000, 100000);

                Console.WriteLine(cuopon);
            }

        }
    }
}
