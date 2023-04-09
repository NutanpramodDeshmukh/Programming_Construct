using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_of_two
{
    internal class Program
    {
        static int max_exponent(int n)
        {
            return (int)(Math.Log(n) / Math.Log(2));
        }
        static void all_powers(int N)
        {
            int total = max_exponent(N);

            char[] arr = new char[total + 2];
            for (int i = 0; i <= total + 1; i++)
                arr[i] = '0';

            for (int i = 1; i < total + 2; i++)
            {
                arr[i - 1] = '0';

                arr[i] = '1';
                Console.Write(Convert.ToInt32(new string(arr), 2) + " ");
            }
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            int N = 63;
            all_powers(N);
        }
    }
}
