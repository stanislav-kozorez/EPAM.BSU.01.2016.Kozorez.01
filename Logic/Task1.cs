using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class Task1
    {
        private const double ACCURACY = 0.0001;
        
        /// <summary>
        /// Returns the root of the y-th power of number x 
        /// </summary>
        public static double Root(double x, double y)
        {
            double Xk = x;
            double result = x;

            if (y == 0)
                throw new ArgumentException("Unable to take root from zero power");
            if (x == 0 && y < 0)
                throw new ArgumentException($"Wrong set of arguments  {nameof(x)} and {nameof(y)}");
            if (x < 0 && y % 2 == 0)
                throw new ArgumentException("Unagle to take root from negative value when power is even number");
            if (x == 0 && y > 0)
                return 0;
            
            do
            {
                Xk = result;
                result = 1 / y * ((y - 1) * Xk + x / (Math.Exp((y - 1) * Math.Log(Xk))));  
            } while (Math.Abs(result - Xk) > ACCURACY);

            return result;
        }

    }
}
