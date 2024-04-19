using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearRatioGenerator
{
    public static class CoprimeGenerator
    {
        /// <summary>
        /// Finds greatest common divisor of inputs
        /// </summary>
        public static int GCD(int a, int b)
        {
            // Check for negative inputs
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }


        /// <summary>
        /// Generate coprimes for given input
        /// </summary>
        /// <param name="input">First term of coprime pairing</param>
        /// <param name="min">Smallest value to test</param>
        /// <param name="max">Largest value to test</param>
        /// <returns></returns>
        public static int[] GenerateCoprimes(int input, int min, int max)
        {
            List<int> coprimeList = [];

            // Check for coprimes and add to list
            for (int i = min; i <= max; i++)
            {
                if (GCD(input, i) == 1)
                {
                    coprimeList.Add(i);
                }
            }

            int[] results = [.. coprimeList];
            return results;
        }
    }
}
