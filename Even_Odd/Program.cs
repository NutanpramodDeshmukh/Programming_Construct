using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, N;
            Console.WriteLine("check number is Even or odd");
            num1 = Convert.ToInt32(Console.ReadLine());
            N = num1 % 2;
            if (N == 0)
            {
                Console.WriteLine(" number is Even ");
            }
            else
            {
                Console.WriteLine(" number is Odd");
            }
        }
    }
}
