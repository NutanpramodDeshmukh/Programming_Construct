using System;


namespace Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Arithmetic operations");
            Console.Write("Enter No1: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter No2: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = Convert.ToInt32(Console.ReadLine());

            switch (c) 
            {
                case 1:
                    Console.WriteLine("Addition" +(a+b));
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Subtraction Of Two Numbers : " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Division Of Two Numbers : " + (a / b));
                    break;
                case 4:
                    Console.WriteLine("Multiplicaion Of Two Numbers : " + (a * b));
                    break;
            }
        }
    }
}
