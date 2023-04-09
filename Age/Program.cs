using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vote_age;
            Console.Write("Input the age of the candidate : ");
            vote_age = Convert.ToInt32(Console.ReadLine());
            if (vote_age < 18)
            {
                Console.Write("Sorry, You are not eligible to caste your vote.\n");
            }
            else
                Console.Write("Congratulation! You are eligible for casting your vote.\n\n");
        }
    }
    }

