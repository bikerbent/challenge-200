using System;
using System.Collections.Generic;
using System.Text;

namespace Bluefragments
{
    class PrimeChecker
    {
        int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

        public PrimeChecker()
        {
        }

        public string IsPrime(int number)
        {
            if (100 > number)
            {
                foreach (int prime in primes)
                {

                    if (number == prime)
                    {
                        return "Yes";
                    }
                }

            }
            else
            {
                return "How should I know?";
            }
            return "No";
        }
    }
}
