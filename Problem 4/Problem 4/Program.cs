using System;
using System.Diagnostics;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine();
            Debug.Assert(IsIntPalindrome(9009) == true);
            Debug.Assert(IsIntPalindrome(99) == true);
            Debug.Assert(IsIntPalindrome(9) == true);
            Debug.Assert(IsIntPalindrome(89) == false);
            Debug.Assert(IsIntPalindrome(8989) == false);

            Console.WriteLine(LargestDigitPalindrome(3));

            

            Console.WriteLine("Program Exiting, all assertions passed. Press any key to close this window.");
            Console.ReadLine();
        }
        static Int64 getLargestIntRoundedBy10(int nbrOfDigits)
        {
            Int64 result = 1, cnt = 1;

            while (cnt <= nbrOfDigits)
            {
                result *= 10;
                cnt++;
            }

            return result;
        }
        static Int64 LargestDigitPalindrome(int nbrOfDigits)
        {
            Int64 ceiling = getLargestIntRoundedBy10(nbrOfDigits) - 1; // offset by 1 since multiple of 10 cannot be a palindrome
            Int64 floor = ceiling;
            Int64 result = 0, maxPalindrome = 0;
            Console.WriteLine(ceiling);

            while (ceiling.ToString().Length == nbrOfDigits)
            {
                bool isPalindrome = false;
                do
                {
                    result = floor * ceiling;
                    isPalindrome = IsIntPalindrome(result);
                    floor--;
                } while (!isPalindrome && floor.ToString().Length == nbrOfDigits);

                if (isPalindrome)
                    maxPalindrome =  Math.Max(maxPalindrome, result);

                ceiling--;
                floor = ceiling;
            }

            Console.WriteLine("{0}, {1}", ceiling, floor + 1);
            return maxPalindrome;
        }
       
        static bool IsIntPalindrome(Int64 nbr)
        {
            string nbrStr = Convert.ToString(nbr);

            for (int i = 0; i < nbrStr.Length / 2; i += 1)
            {
                if (nbrStr[i] != nbrStr[nbrStr.Length - 1 - i])
                    return false;
            }

            return true;
        }
    }
}
