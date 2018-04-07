﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    /// <summary>Provides tools for trigonometrical functions in mathematics.</summary>
    public static class Trigonometry
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
        /// <summary>Returns the cotangent value of an angle.</summary>
        /// <param name="radians">The value of the angle in radians.</param>
        public static decimal Cotangent(decimal radians) => General.Invert(Tangent(radians));
        /// <summary>Returns the cotangent value of an angle.</summary>
        /// <param name="angle">The value of the angle in the prefered measurement unit.</param>
        /// <param name="measurementUnit">The angle measurement unit to use.</param>
        public static decimal Cotangent(decimal angle, AngleMeasurementUnit measurementUnit) => General.Invert(Tangent(angle, measurementUnit));
        /// <summary>Returns the secant value of an angle.</summary>
        /// <param name="radians">The value of the angle in radians.</param>
        public static decimal Secant(decimal radians) => General.Invert(Cosine(radians));
        /// <summary>Returns the secant value of an angle.</summary>
        /// <param name="angle">The value of the angle in the prefered measurement unit.</param>
        /// <param name="measurementUnit">The angle measurement unit to use.</param>
        public static decimal Secant(decimal angle, AngleMeasurementUnit measurementUnit) => General.Invert(Cosine(angle, measurementUnit));
        /// <summary>Returns the cosecant value of an angle.</summary>
        /// <param name="radians">The value of the angle in radians.</param>
        public static decimal Cosecant(decimal radians) => General.Invert(Sine(radians));
        /// <summary>Returns the cosecant value of an angle.</summary>
        /// <param name="angle">The value of the angle in the prefered measurement unit.</param>
        /// <param name="measurementUnit">The angle measurement unit to use.</param>
        public static decimal Cosecant(decimal angle, AngleMeasurementUnit measurementUnit) => General.Invert(Sine(angle, measurementUnit));


        /// <summary>Returns the arcsine of a value in radians.</summary>
        /// <param name="value">The value to return the arcsine of.</param>
        public static decimal ArcSine(decimal value)
        {
            if (value >= -1 && value <= 1)
            {
                decimal result = value;
                decimal previousResult = 0;
                int i = 0;
                double currentFactorization;
                double denominatorCoefficient;
                while (result != previousResult) // Quick way to check whether the precision is enough
                {
                    previousResult = result;
                    currentFactorization = General.Factorization(i, 2 * i);
                    denominatorCoefficient = General.Power(4, i);
                    result += (decimal)((currentFactorization * General.Power(value, (2 * i + 1))) / (denominatorCoefficient * (2 * i + 1)));
                    i++;
                }
                return result;
            }
            else
                throw new ArgumentOutOfRangeException("The domain of arcsine is the interval [-1, 1].");
        }
        /// <summary>Returns the arctangent of a value in radians.</summary>
        /// <param name="value">The value to return the arctangent of.</param>
        public static decimal ArcTangent(decimal value)
        {
            decimal result = value / (1 + value * value); // Initialization of the result
            decimal resultCoefficient = 0;
            decimal previousResult = 0;
            int i = 1;
            double currentFactorial = 1;
            decimal valueSquared = (decimal)General.Power(value, 2);
            decimal valueSquaredPlusOne = valueSquared + 1;
            decimal doubleValueSquared = 2 * valueSquared;
            while (resultCoefficient != previousResult) // Quick way to check whether the precision is enough
            {
                decimal product = 1;
                for (int j = 1; j <= i; j++)
                    product *= (j * doubleValueSquared) / ((2 * j + 1) * valueSquaredPlusOne);
                previousResult = resultCoefficient;
                currentFactorial *= General.Factorization(2 * (i - 1) + 1, 2 * i + 1);
                resultCoefficient += product;
                i++;
            }
            result *= resultCoefficient;
            return result;
        }

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
