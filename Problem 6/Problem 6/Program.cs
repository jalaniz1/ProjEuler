using System;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            const int start = 1, max = 100;

            Console.WriteLine(SumOfSquares(start, max));
            Console.WriteLine(SquareOfSum(start, max));
            Console.WriteLine(SquareOfSum(start, max) - SumOfSquares(1, max));
            Console.ReadLine();
        }

        static int SumOfSquares(int start, int max)
        {
            int cnt = start, sum = 0;

            while(cnt <= max)
            {
                sum += (int)Math.Pow(cnt, 2);
                cnt++;
            }

            return sum;
        }

        static int SquareOfSum(int start, int max)
        {
            int cnt = start, sum = 0;

            while(cnt <= max)
            {
                sum += cnt;
                cnt++;
            }

            return (int)Math.Pow(sum, 2);
        }
    }
}
