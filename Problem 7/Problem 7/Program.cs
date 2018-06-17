using System;
using System.Collections.Generic;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine(String.Join(",", PrimeNbrAtPos(3)));
            Console.ReadLine();
        }


        static int PrimeNbrAtPos(int pos)
        {

            if (pos < 1)
                return 0;
            else if (pos == 1)
                return 2;

            int cnt = 1, i = 2;

            while(cnt < pos)
            {
                i++;
                int divisor = (int)Math.Ceiling(Math.Sqrt(i));
                bool isPrime = true;
                
                while (divisor > 1 && isPrime) { isPrime = i % divisor != 0 ? true : false; divisor--; }

                if (isPrime)
                    cnt++;
            }

            return i;
        }
    }
}
