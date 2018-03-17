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
            double currentFactorial = 1;
            double currentPower = (double)radians;
            double radiansSquared = General.Power(radians, 2);
            double currentSign = -1;
            while (result != previousResult) // Quick way to check whether the precision is enough
            {
                // Efficient progressive calculation
                previousResult = result;
                currentFactorial *= General.Factorization(2 * (i - 1) + 1, 2 * i + 1);
                currentPower *= radiansSquared;
                currentSign *= -1;
                result += (decimal)(currentSign / currentFactorial * currentPower);
                i++;
            }
            return result;
        }
        /// <summary>Returns the sine value of an angle.</summary>
        /// <param name="angle">The value of the angle in the prefered measurement unit.</param>
        /// <param name="measurementUnit">The angle measurement unit to use.</param>
        public static decimal Sine(decimal angle, AngleMeasurementUnit measurementUnit) => Sine(ConvertAngle(angle, measurementUnit, AngleMeasurementUnit.Radians));
        /// <summary>Returns the cosine value of an angle.</summary>
        /// <param name="radians">The value of the angle in radians.</param>
        public static decimal Cosine(decimal radians) => (decimal)General.SquareRoot(1 - General.Power(Sine(radians), 2)); // Some precision is lost during the process
        /// <summary>Returns the cosine value of an angle.</summary>
        /// <param name="angle">The value of the angle in the prefered measurement unit.</param>
        /// <param name="measurementUnit">The angle measurement unit to use.</param>
        public static decimal Cosine(decimal angle, AngleMeasurementUnit measurementUnit) => (decimal)General.SquareRoot(1 - General.Power(Sine(angle, measurementUnit), 2));
        /// <summary>Returns the tangent value of an angle.</summary>
        /// <param name="radians">The value of the angle in radians.</param>
        public static decimal Tangent(decimal radians) => (decimal)General.SquareRoot(1 - General.Power(Sine(radians), 2));
        /// <summary>Returns the tangent value of an angle.</summary>
        /// <param name="angle">The value of the angle in the prefered measurement unit.</param>
        /// <param name="measurementUnit">The angle measurement unit to use.</param>
        public static decimal Tangent(decimal angle, AngleMeasurementUnit measurementUnit) => (decimal)General.SquareRoot(1 - General.Power(Sine(angle, measurementUnit), 2));
        /// <summary>Returns the cptangent value of an angle.</summary>
        /// <param name="radians">The value of the angle in radians.</param>
        public static decimal Cotangent(decimal radians) => General.Invert(Tangent(radians));
        /// <summary>Returns the cotangent value of an angle.</summary>
        /// <param name="angle">The value of the angle in the prefered measurement unit.</param>
        /// <param name="measurementUnit">The angle measurement unit to use.</param>
        public static decimal Cotangent(decimal angle, AngleMeasurementUnit measurementUnit) => General.Invert(Tangent(angle, measurementUnit));

        /// <summary>Converts the angle from one measurement unit to another.</summary>
        /// <param name="angle">The angle to convert.</param>
        /// <param name="originalUnit">The unit the parsed angle is based on.</param>
        /// <param name="conversionUnit">The unit the returned value is based on.</param>
        public static decimal ConvertAngle(decimal angle, AngleMeasurementUnit originalUnit, AngleMeasurementUnit conversionUnit)
        {
            decimal result = angle;
            if (originalUnit != conversionUnit) // Sorted based on estimated execution frequency
            {
                if (originalUnit == AngleMeasurementUnit.Degrees && conversionUnit == AngleMeasurementUnit.Radians)
                    result *= General.Pi / 180;
                else if (originalUnit == AngleMeasurementUnit.Radians && conversionUnit == AngleMeasurementUnit.Degrees)
                    result *= 180 / General.Pi;
                else if (originalUnit == AngleMeasurementUnit.Gradians && conversionUnit == AngleMeasurementUnit.Degrees)
                    result *= 9 / 10;
                else if (originalUnit == AngleMeasurementUnit.Degrees && conversionUnit == AngleMeasurementUnit.Gradians)
                    result *= 10 / 9;
                else if (originalUnit == AngleMeasurementUnit.Gradians && conversionUnit == AngleMeasurementUnit.Radians)
                    result *= General.Pi / 200;
                else if (originalUnit == AngleMeasurementUnit.Radians && conversionUnit == AngleMeasurementUnit.Gradians)
                    result *= 200 / General.Pi;
            }
            return result;
        }
    }
}