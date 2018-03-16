using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    /// <summary>Provides tools for trigonometrical functions in mathematics.</summary>
    public class Trigonometry
    {
        /// <summary>Returns the sine value of an angle.</summary>
        /// <param name="radians">The value of the angle in radians.</param>
        public static decimal Sine(decimal radians)
        {
            decimal result = radians;
            decimal previousResult = 0;
            int i = 1;
            decimal currentFactorial = 1;
            decimal currentPower = radians;
            decimal radiansSquared = General.Power(radians, 2);
            decimal currentSign = -1;
            while (result != previousResult) // Quick way to check whether the precision is enough
            {
                // Efficient progressive calculation
                previousResult = result;
                currentFactorial *= General.Factorization(2 * (i - 1) + 1, 2 * i + 1);
                currentPower *= radiansSquared;
                currentSign *= -1;
                result += (currentSign / currentFactorial * currentPower);
                i++;
            }
            return result;
        }
        /// <summary>Returns the sine value of an angle.</summary>
        /// <param name="angle">The value of the angle in the prefered measurement unit.</param>
        /// <param name="measurementUnit">The angle measurement unit to use.</param>
        public static decimal Sine(decimal angle, AngleMeasurementUnit measurementUnit)
        {
            decimal radians;
            if (measurementUnit == AngleMeasurementUnit.Degrees)
                radians = General.Pi / 180 * angle;
            else if (measurementUnit == AngleMeasurementUnit.Gradians)
                radians = General.Pi / 200 * angle;
            else
                radians = angle;
            return Sine(radians);            
        }
    }
}