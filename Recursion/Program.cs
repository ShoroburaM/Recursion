using System;

namespace Recursion
{
    class Program
    {
        static uint Factorial(uint f)
        {
            if (f == 0)
            {
                return 1;
            }
            else
            {
                return  f * Factorial(f - 1); 
            }
          
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Put some velue");
            uint factorial = uint.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of " + factorial+ " is: " + Factorial(factorial));
            Console.ReadLine();
        }
    }
}
