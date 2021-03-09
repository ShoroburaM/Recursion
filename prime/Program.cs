using System;

namespace prime
{
    
    class Program
    {
        static string PrimeN(int n)
        {
            int i, m;
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    return "Number is not Prime.";
                }
            }
            return "Number is Prime.";
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the Number to check Prime: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(PrimeN(n));
        }
    }
}
