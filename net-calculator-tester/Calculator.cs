using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calc
    {
        public static float Add(float x, float y) { return x + y; }

        public static float Subtract(float x, float y) { return x - y; }

        public static float Divide(float x, float y) 
        {
            if (x == 0 && y == 0)
            {
                return (float.NaN);
            }
            else if (x > 0 && y == 0)
            {
                return (float.PositiveInfinity);

            }
            else if (x < 0 && y == 0)
            {
                return (float.NegativeInfinity);

            }
            else 
            { 
                return x / y;
            }
        }

        public static float Multiply(float x, float y) { return x * y; }
    }
}


