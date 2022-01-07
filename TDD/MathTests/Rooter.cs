using System;

namespace MathTests
{
    public class Rooter
    {
        public Rooter()
        {
        }

        public double SquareRoot(double input)
        {
            if (input <= 0.0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Math.Sqrt(input);
        }
    }
}