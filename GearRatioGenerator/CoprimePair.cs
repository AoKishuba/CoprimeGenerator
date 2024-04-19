using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearRatioGenerator
{
    public class CoprimePair
    {
        /// <summary>
        /// Includes pair and information on relations to desired gear ratio
        /// </summary>
        /// <param name="a">First member of coprime pairing</param>
        /// <param name="b">Second member of coprime pairing</param>
        /// <param name="desiredRatio">User input desired gear ratio</param>
        public CoprimePair(int a, int b, decimal desiredRatio)
        {
            FirstCoprime = a;
            SecondCoprime = b;
            RealRatio = (decimal)a / b;
            RatioError = (desiredRatio - RealRatio) / RealRatio;
            ErrorMagnitude = RatioError < 0 ? -RatioError : RatioError;
        }

        public int FirstCoprime;
        public int SecondCoprime;
        public decimal RealRatio;
        public decimal RatioError;
        public decimal ErrorMagnitude;
        public decimal NormalizedErrorMagnitude = 0;

        public override string ToString()
        {
            return $"{FirstCoprime},{SecondCoprime},{RealRatio},{RatioError},{ErrorMagnitude},{NormalizedErrorMagnitude}";
        }
    }
}
