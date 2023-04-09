using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twointeger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Check whether two integers are equal or not:\n");
            Console.WriteLine("Check 1st integer number:\n");
            num1 = Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine("Check 2st integer number:\n");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("{0} and {1} are equal.\n", num1, num2);
            }
            else {
                Console.WriteLine("{0} and {1} are not equal.\n", num1, num2);
            }


        }
    }
}
