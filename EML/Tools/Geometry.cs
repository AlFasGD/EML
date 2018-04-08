using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    /// <summary>Provides tools for operations in geometry.</summary>
    public static class Geometry
    {
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