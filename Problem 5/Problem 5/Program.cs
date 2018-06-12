using System;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine(GetSmallestDivisibleNbrByRange(1, 20));
            Console.ReadLine();
        }

        static bool IsNbrNotEvenlyDivisibleBy(int nbr, int divisor)
        {
            return nbr % divisor != 0;
        }

        static int GetSmallestDivisibleNbrByRange(int start, int max)
        {

            int cnt = start, curNbr = 1;
            
            while (cnt <= max)
            {
                 
                if(IsNbrNotEvenlyDivisibleBy(curNbr, divisor: cnt))
                {
                    cnt = start;
                    curNbr++;
                    continue;
                }

                cnt++;
            }

            return curNbr;
        }
    }
}
