using System;

namespace Fibonachi
{
    class Program
    {
        static int Fibonachi(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Put some velue");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.Write(Fibonachi(i));
                Console.Write(" ");
                
            }
            Console.ReadLine();

        }
    }
}
