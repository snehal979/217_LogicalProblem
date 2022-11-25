using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class Reverse
    {
        public static void Reverse_Number()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int digit = 0;
            int reverse = 0;
            while (num != 0)
            {
                digit = num % 10;
                reverse = reverse * 10 + digit;
                num = num / 10;
            }

            Console.WriteLine("The reverse number" +reverse);




        }
    }
}
