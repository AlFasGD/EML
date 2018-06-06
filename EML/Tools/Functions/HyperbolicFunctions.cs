using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Tools.Functions
{
    /// <summary>Provides tools for hyperbolic functions in mathematics.</summary>
    public static class HyperbolicFunctions
    {
        #region Hyperbolic Functions
        /// <summary>Returns the hyperbolic sine (sinh) value of an angle.</summary>
        /// <param name="radians">The value of the angle in radians.</param>
        public static decimal Sineh(decimal radians)
        {
            decimal exponentation = (decimal)General.Exponentation(radians);
            return (exponentation - General.Invert(exponentation)) / 2;
        }
        /// <summary>Returns the hyperbolic sine (sinh) value of an angle.</summary>
        /// <param name="angle">The value of the angle in the prefered measurement unit.</param>
        /// <param name="measurementUnit">The angle measurement unit to use.</param>
        public static decimal Sineh(decimal angle, AngleMeasurementUnit measurementUnit) => Sineh(Geometry.ConvertAngle(angle, measurementUnit, AngleMeasurementUnit.Radians));
        /// <summary>Returns the hyperbolic cosine (cosh) value of an angle.</summary>
        /// <param name="radians">The value of the angle in radians.</param>
        public static decimal Cosineh(decimal radians)
        {
            decimal exponentation = (decimal)General.Exponentation(radians);
            return (exponentation + General.Invert(exponentation)) / 2;
        }
        /// <summary>Returns the hyperbolic cosine (cosh) value of an angle.</summary>
        /// <param name="angle">The value of the angle in the prefered measurement unit.</param>
        /// <param name="measurementUnit">The angle measurement unit to use.</param>
        public static decimal Cosineh(decimal angle, AngleMeasurementUnit measurementUnit) => Cosineh(Geometry.ConvertAngle(angle, measurementUnit, AngleMeasurementUnit.Radians));
        /// <summary>Returns the hyperbolic tangent (tanh) value of an angle.</summary>
        /// <param name="radians">The value of the angle in radians.</param>
        public static decimal Tangenth(decimal radians)
        {
            decimal exponentation = (decimal)General.Exponentation(radians);
            decimal invertedExponentation = General.Invert(exponentation);
            return (exponentation - invertedExponentation) / (exponentation + invertedExponentation);
        }
        /// <summary>Returns the hyperbolic tangent (tanh) value of an angle.</summary>
        /// <param name="angle">The value of the angle in the prefered measurement unit.</param>
        /// <param name="measurementUnit">The angle measurement unit to use.</param>
        public static decimal Tangenth(decimal angle, AngleMeasurementUnit measurementUnit) => Tangenth(Geometry.ConvertAngle(angle, measurementUnit, AngleMeasurementUnit.Radians));
        /// <summary>Returns the hyperbolic cotangent (coth) value of an angle.</summary>
        /// <param name="radians">The value of the angle in radians.</param>
        public static decimal Cotangenth(decimal radians)
        {
            decimal exponentation = (decimal)General.Exponentation(radians);
            decimal invertedExponentation = General.Invert(exponentation);
            return (exponentation + invertedExponentation) / (exponentation - invertedExponentation);
        }
        /// <summary>Returns the hyperbolic cotangent (coth) value of an angle.</summary>
        /// <param name="angle">The value of the angle in the prefered measurement unit.</param>
        /// <param name="measurementUnit">The angle measurement unit to use.</param>
        public static decimal Cotangenth(decimal angle, AngleMeasurementUnit measurementUnit) => Cotangenth(Geometry.ConvertAngle(angle, measurementUnit, AngleMeasurementUnit.Radians));
        /// <summary>Returns the hyperbolic secant (sech) value of an angle.</summary>
        /// <param name="radians">The value of the angle in radians.</param>
        public static decimal Secanth(decimal radians)
        {
            decimal exponentation = (decimal)General.Exponentation(radians);
            return 2 / (exponentation + General.Invert(exponentation));
        }
        /// <summary>Returns the hyperbolic secant (sech) value of an angle.</summary>
        /// <param name="angle">The value of the angle in the prefered measurement unit.</param>
        /// <param name="measurementUnit">The angle measurement unit to use.</param>
        public static decimal Secanth(decimal angle, AngleMeasurementUnit measurementUnit) => Secanth(Geometry.ConvertAngle(angle, measurementUnit, AngleMeasurementUnit.Radians));
        /// <summary>Returns the hyperbolic cosecant (csch) value of an angle.</summary>
        /// <param name="radians">The value of the angle in radians.</param>
        public static decimal Cosecanth(decimal radians)
        {
            decimal exponentation = (decimal)General.Exponentation(radians);
            return 2 / (exponentation - General.Invert(exponentation));
        }
        /// <summary>Returns the hyperbolic cosecant (csch) value of an angle.</summary>
        /// <param name="angle">The value of the angle in the prefered measurement unit.</param>
        /// <param name="measurementUnit">The angle measurement unit to use.</param>
        public static decimal Cosecanth(decimal angle, AngleMeasurementUnit measurementUnit) => Cosecanth(Geometry.ConvertAngle(angle, measurementUnit, AngleMeasurementUnit.Radians));
        #endregion

        #region Inverse Hyperbolic Functions
        /// <summary>Returns the inverse hyperbolic sine (arcsinh) value of a value in radians.</summary>
        /// <param name="value">The value to return the arcsinh of.</param>
        public static decimal ArcSineh(decimal value) => (decimal)General.Ln(value + General.SquareRoot(value * value + 1));
        /// <summary>Returns the inverse hyperbolic cosine (arccosh) value of a value in radians.</summary>
        /// <param name="value">The value to return the arccosh of.</param>
        public static decimal ArcCosineh(decimal value)
        {
            if (value >= 1)
                return (decimal)General.Ln(value + General.SquareRoot(value * value - 1));
            else
                throw new ArgumentOutOfRangeException("The domain of arccosh is the interval ∪[1, +∞).");
        }
        /// <summary>Returns the inverse hyperbolic tangent (arctanh) value of a value in radians.</summary>
        /// <param name="value">The value to return the arctanh of.</param>
        public static decimal ArcTangenth(decimal value)
        {
            if (General.AbsoluteValue(value) < 1)
                return (decimal)General.Ln((1 + value) / (1 - value)) / 2;
            else
                throw new ArgumentOutOfRangeException("The domain of arctanh is (-1, 1).");
        }
        /// <summary>Returns the inverse hyperbolic cotangent (arccoth) value of a value in radians.</summary>
        /// <param name="value">The value to return the arccoth of.</param>
        public static decimal ArcCotangenth(decimal value)
        {
            if (General.AbsoluteValue(value) > 1)
                return (decimal)General.Ln((value + 1) / (value - 1)) / 2;
            else
                throw new ArgumentOutOfRangeException("The domain of arccoth is (-∞, -1)∪(1, +∞).");
        }
        /// <summary>Returns the inverse hyperbolic secant (arcsech) value of a value in radians.</summary>
        /// <param name="value">The value to return the arcsech of.</param>
        public static decimal ArcSecanth(decimal value)
        {
            if (0 < value && value <= 1)
                return (decimal)General.Ln(1 + General.SquareRoot(1 - value * value) / value);
            else
                throw new ArgumentOutOfRangeException("The domain of arcsech is (0, 1].");
        }
        /// <summary>Returns the inverse hyperbolic cosecant (arccsch) value of a value in radians.</summary>
        /// <param name="value">The value to return the arccsch of.</param>
        public static decimal ArcCosecanth(decimal value)
        {
            if (value != 0)
                return (decimal)General.Ln(1 + General.SquareRoot(1 + value * value) / value);
            else
                throw new ArgumentOutOfRangeException("The domain of arccsch is (-∞, 0)∪(0, +∞).");
        }
        #endregion
    }
}