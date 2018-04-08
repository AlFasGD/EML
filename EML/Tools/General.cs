using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    /// <summary>Contains general operations in mathematics.</summary>
    public static class General
    {
        #region Constants
        /// <summary>The constant π with 39-digit precision (supposedly). This precision is enough for precise calculations in an atomic scale.</summary>
        public const decimal Pi  = 3.141592653589793238462643383279502884197m;
        /// <summary>The constant e with 50-digit precision (supposedly).</summary>
        public const decimal e   = 2.71828182845904523536028747135266249775724709369995m;
        /// <summary>The constant φ with 50-digit precision (supposedly).</summary>
        public const decimal Phi = 1.61803398874989484820458683436563811772030917980576m;
        #endregion

        #region Min
        /// <summary>Returns the smallest value of a <seealso cref="char"/> array.</summary>
        /// <param name="a">The <seealso cref="char"/> array.</param>
        public static char Min(params char[] a)
        {
            char min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (min > a[i])
                    min = a[i];
            return min;
        }
        /// <summary>Returns the smallest value of a <seealso cref="byte"/> array.</summary>
        /// <param name="a">The <seealso cref="byte"/> array.</param>
        public static byte Min(params byte[] a)
        {
            byte min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (min > a[i])
                    min = a[i];
            return min;
        }
        /// <summary>Returns the smallest value of a <seealso cref="short"/> array.</summary>
        /// <param name="a">The <seealso cref="short"/> array.</param>
        public static short Min(params short[] a)
        {
            short min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (min > a[i])
                    min = a[i];
            return min;
        }
        /// <summary>Returns the smallest value of a <seealso cref="int"/> array.</summary>
        /// <param name="a">The <seealso cref="int"/> array.</param>
        public static int Min(params int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (min > a[i])
                    min = a[i];
            return min;
        }
        /// <summary>Returns the smallest value of a <seealso cref="long"/> array.</summary>
        /// <param name="a">The <seealso cref="long"/> array.</param>
        public static long Min(params long[] a)
        {
            long min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (min > a[i])
                    min = a[i];
            return min;
        }
        /// <summary>Returns the smallest value of a <seealso cref="sbyte"/> array.</summary>
        /// <param name="a">The <seealso cref="sbyte"/> array.</param>
        public static sbyte Min(params sbyte[] a)
        {
            sbyte min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (min > a[i])
                    min = a[i];
            return min;
        }
        /// <summary>Returns the smallest value of a <seealso cref="ushort"/> array.</summary>
        /// <param name="a">The <seealso cref="ushort"/> array.</param>
        public static ushort Min(params ushort[] a)
        {
            ushort min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (min > a[i])
                    min = a[i];
            return min;
        }
        /// <summary>Returns the smallest value of a <seealso cref="uint"/> array.</summary>
        /// <param name="a">The <seealso cref="uint"/> array.</param>
        public static uint Min(params uint[] a)
        {
            uint min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (min > a[i])
                    min = a[i];
            return min;
        }
        /// <summary>Returns the smallest value of a <seealso cref="ulong"/> array.</summary>
        /// <param name="a">The <seealso cref="ulong"/> array.</param>
        public static ulong Min(params ulong[] a)
        {
            ulong min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (min > a[i])
                    min = a[i];
            return min;
        }
        /// <summary>Returns the smallest value of a <seealso cref="float"/> array.</summary>
        /// <param name="a">The <seealso cref="float"/> array.</param>
        public static float Min(params float[] a)
        {
            float min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (min > a[i])
                    min = a[i];
            return min;
        }
        /// <summary>Returns the smallest value of a <seealso cref="double"/> array.</summary>
        /// <param name="a">The <seealso cref="double"/> array.</param>
        public static double Min(params double[] a)
        {
            double min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (min > a[i])
                    min = a[i];
            return min;
        }
        /// <summary>Returns the smallest value of a <seealso cref="decimal"/> array.</summary>
        /// <param name="a">The <seealso cref="decimal"/> array.</param>
        public static decimal Min(params decimal[] a)
        {
            decimal min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (min > a[i])
                    min = a[i];
            return min;
        }
        #endregion
        #region Max
        /// <summary>Returns the greatest value of a <seealso cref="char"/> array.</summary>
        /// <param name="a">The <seealso cref="char"/> array.</param>
        public static char Max(params char[] a)
        {
            char max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (max < a[i])
                    max = a[i];
            return max;
        }
        /// <summary>Returns the greatest value of a <seealso cref="byte"/> array.</summary>
        /// <param name="a">The <seealso cref="byte"/> array.</param>
        public static byte Max(params byte[] a)
        {
            byte max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (max < a[i])
                    max = a[i];
            return max;
        }
        /// <summary>Returns the greatest value of a <seealso cref="short"/> array.</summary>
        /// <param name="a">The <seealso cref="short"/> array.</param>
        public static short Max(params short[] a)
        {
            short max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (max < a[i])
                    max = a[i];
            return max;
        }
        /// <summary>Returns the greatest value of a <seealso cref="int"/> array.</summary>
        /// <param name="a">The <seealso cref="int"/> array.</param>
        public static int Max(params int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (max < a[i])
                    max = a[i];
            return max;
        }
        /// <summary>Returns the greatest value of a <seealso cref="long"/> array.</summary>
        /// <param name="a">The <seealso cref="long"/> array.</param>
        public static long Max(params long[] a)
        {
            long max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (max < a[i])
                    max = a[i];
            return max;
        }
        /// <summary>Returns the greatest value of a <seealso cref="sbyte"/> array.</summary>
        /// <param name="a">The <seealso cref="sbyte"/> array.</param>
        public static sbyte Max(params sbyte[] a)
        {
            sbyte max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (max < a[i])
                    max = a[i];
            return max;
        }
        /// <summary>Returns the greatest value of a <seealso cref="ushort"/> array.</summary>
        /// <param name="a">The <seealso cref="ushort"/> array.</param>
        public static ushort Max(params ushort[] a)
        {
            ushort max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (max < a[i])
                    max = a[i];
            return max;
        }
        /// <summary>Returns the greatest value of a <seealso cref="uint"/> array.</summary>
        /// <param name="a">The <seealso cref="uint"/> array.</param>
        public static uint Max(params uint[] a)
        {
            uint max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (max < a[i])
                    max = a[i];
            return max;
        }
        /// <summary>Returns the greatest value of a <seealso cref="ulong"/> array.</summary>
        /// <param name="a">The <seealso cref="ulong"/> array.</param>
        public static ulong Max(params ulong[] a)
        {
            ulong max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (max < a[i])
                    max = a[i];
            return max;
        }
        /// <summary>Returns the greatest value of a <seealso cref="float"/> array.</summary>
        /// <param name="a">The <seealso cref="float"/> array.</param>
        public static float Max(params float[] a)
        {
            float max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (max < a[i])
                    max = a[i];
            return max;
        }
        /// <summary>Returns the greatest value of a <seealso cref="double"/> array.</summary>
        /// <param name="a">The <seealso cref="double"/> array.</param>
        public static double Max(params double[] a)
        {
            double max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (max < a[i])
                    max = a[i];
            return max;
        }
        /// <summary>Returns the greatest value of a <seealso cref="decimal"/> array.</summary>
        /// <param name="a">The <seealso cref="decimal"/> array.</param>
        public static decimal Max(params decimal[] a)
        {
            decimal max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (max < a[i])
                    max = a[i];
            return max;
        }
        #endregion
        #region Absolute Value
        /// <summary>Returns the absolute value of a <seealso cref="sbyte"/>.</summary>
        /// <param name="a">The <seealso cref="sbyte"/> whose absolute value to return.</param>
        public static sbyte AbsoluteValue(sbyte a) => a > 0 ? a : (sbyte)-a;
        /// <summary>Returns the absolute value of a <seealso cref="short"/>.</summary>
        /// <param name="a">The <seealso cref="short"/> whose absolute value to return.</param>
        public static short AbsoluteValue(short a) => a > 0 ? a : (short)-a;
        /// <summary>Returns the absolute value of a <seealso cref="int"/>.</summary>
        /// <param name="a">The <seealso cref="int"/> whose absolute value to return.</param>
        public static int AbsoluteValue(int a) => a > 0 ? a : -a;
        /// <summary>Returns the absolute value of a <seealso cref="long"/>.</summary>
        /// <param name="a">The <seealso cref="long"/> whose absolute value to return.</param>
        public static long AbsoluteValue(long a) => a > 0 ? a : -a;
        /// <summary>Returns the absolute value of a <seealso cref="float"/>.</summary>
        /// <param name="a">The <seealso cref="float"/> whose absolute value to return.</param>
        public static float AbsoluteValue(float a) => a > 0 ? a : -a;
        /// <summary>Returns the absolute value of a <seealso cref="double"/>.</summary>
        /// <param name="a">The <seealso cref="double"/> whose absolute value to return.</param>
        public static double AbsoluteValue(double a) => a > 0 ? a : -a;
        /// <summary>Returns the absolute value of a <seealso cref="decimal"/>.</summary>
        /// <param name="a">The <seealso cref="decimal"/> whose absolute value to return.</param>
        public static decimal AbsoluteValue(decimal a) => a > 0 ? a : -a;
        #endregion
        #region Invert
        /// <summary>Returns the inverted value of a <seealso cref="float"/>.</summary>
        /// <param name="d">The <seealso cref="float"/> whose inverted value to return.</param>
        public static float Invert(float d) => 1 / d;
        /// <summary>Returns the inverted value of a <seealso cref="double"/>.</summary>
        /// <param name="d">The <seealso cref="double"/> whose inverted value to return.</param>
        public static double Invert(double d) => 1 / d;
        /// <summary>Returns the inverted value of a <seealso cref="decimal"/>.</summary>
        /// <param name="d">The <seealso cref="decimal"/> whose inverted value to return.</param>
        public static decimal Invert(decimal d) => 1 / d;
        #endregion
        #region Exponentation
        /// <summary>Returns the exponentation of a number (e raised to a power).</summary>
        /// <param name="n">The number to raise e.</param>
        public static double Exponentation(byte n)
        {
            double result = 1;
            double previousResult = 0;
            double currentFactorial = 1;
            double currentPower = 1;
            double i = 1;
            while (result != previousResult)
            {
                previousResult = result;
                currentFactorial *= i;
                currentPower *= n;
                result += currentPower / currentFactorial;
                i++;
            }
            return result;
        }
        /// <summary>Returns the exponentation of a number (e raised to a power).</summary>
        /// <param name="n">The number to raise e.</param>
        public static double Exponentation(short n)
        {
            double result = 1;
            double previousResult = 0;
            double currentFactorial = 1;
            double currentPower = 1;
            double i = 1;
            while (result != previousResult)
            {
                previousResult = result;
                currentFactorial *= i;
                currentPower *= n;
                result += currentPower / currentFactorial;
                i++;
            }
            return result;
        }
        /// <summary>Returns the exponentation of a number (e raised to a power).</summary>
        /// <param name="n">The number to raise e.</param>
        public static double Exponentation(int n)
        {
            double result = 1;
            double previousResult = 0;
            double currentFactorial = 1;
            double currentPower = 1;
            double i = 1;
            while (result != previousResult)
            {
                previousResult = result;
                currentFactorial *= i;
                currentPower *= n;
                result += currentPower / currentFactorial;
                i++;
            }
            return result;
        }
        /// <summary>Returns the exponentation of a number (e raised to a power).</summary>
        /// <param name="n">The number to raise e.</param>
        public static double Exponentation(long n)
        {
            double result = 1;
            double previousResult = 0;
            double currentFactorial = 1;
            double currentPower = 1;
            double i = 1;
            while (result != previousResult)
            {
                previousResult = result;
                currentFactorial *= i;
                currentPower *= n;
                result += currentPower / currentFactorial;
                i++;
            }
            return result;
        }
        /// <summary>Returns the exponentation of a number (e raised to a power).</summary>
        /// <param name="n">The number to raise e.</param>
        public static double Exponentation(sbyte n)
        {
            double result = 1;
            double previousResult = 0;
            double currentFactorial = 1;
            double currentPower = 1;
            double i = 1;
            while (result != previousResult)
            {
                previousResult = result;
                currentFactorial *= i;
                currentPower *= n;
                result += currentPower / currentFactorial;
                i++;
            }
            return result;
        }
        /// <summary>Returns the exponentation of a number (e raised to a power).</summary>
        /// <param name="n">The number to raise e.</param>
        public static double Exponentation(ushort n)
        {
            double result = 1;
            double previousResult = 0;
            double currentFactorial = 1;
            double currentPower = 1;
            double i = 1;
            while (result != previousResult)
            {
                previousResult = result;
                currentFactorial *= i;
                currentPower *= n;
                result += currentPower / currentFactorial;
                i++;
            }
            return result;
        }
        /// <summary>Returns the exponentation of a number (e raised to a power).</summary>
        /// <param name="n">The number to raise e.</param>
        public static double Exponentation(uint n)
        {
            double result = 1;
            double previousResult = 0;
            double currentFactorial = 1;
            double currentPower = 1;
            double i = 1;
            while (result != previousResult)
            {
                previousResult = result;
                currentFactorial *= i;
                currentPower *= n;
                result += currentPower / currentFactorial;
                i++;
            }
            return result;
        }
        /// <summary>Returns the exponentation of a number (e raised to a power).</summary>
        /// <param name="n">The number to raise e.</param>
        public static double Exponentation(ulong n)
        {
            double result = 1;
            double previousResult = 0;
            double currentFactorial = 1;
            double currentPower = 1;
            double i = 1;
            while (result != previousResult)
            {
                previousResult = result;
                currentFactorial *= i;
                currentPower *= n;
                result += currentPower / currentFactorial;
                i++;
            }
            return result;
        }
        /// <summary>Returns the exponentation of a number (e raised to a power).</summary>
        /// <param name="n">The number to raise e.</param>
        public static double Exponentation(float n)
        {
            double result = 1;
            double previousResult = 0;
            double currentFactorial = 1;
            double currentPower = 1;
            double i = 1;
            while (result != previousResult)
            {
                previousResult = result;
                currentFactorial *= i;
                currentPower *= n;
                result += currentPower / currentFactorial;
                i++;
            }
            return result;
        }
        /// <summary>Returns the exponentation of a number (e raised to a power).</summary>
        /// <param name="n">The number to raise e.</param>
        public static double Exponentation(double n)
        {
            double result = 1;
            double previousResult = 0;
            double currentFactorial = 1;
            double currentPower = 1;
            double i = 1;
            while (result != previousResult)
            {
                previousResult = result;
                currentFactorial *= i;
                currentPower *= n;
                result += currentPower / currentFactorial;
                i++;
            }
            return result;
        }
        /// <summary>Returns the exponentation of a number (e raised to a power).</summary>
        /// <param name="n">The number to raise e.</param>
        public static double Exponentation(decimal n)
        {
            double result = 1;
            double previousResult = 0;
            double currentFactorial = 1;
            double currentPower = 1;
            double i = 1;
            while (result != previousResult)
            {
                previousResult = result;
                currentFactorial *= i;
                currentPower *= (double)n;
                result += currentPower / currentFactorial;
                i++;
            }
            return result;
        }
        #endregion
        #region Power
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static double Power(byte b, int power)
        {
            if (b != 0)
            {
                if (power == 0)
                    return 1;
                else if (power == 1)
                    return b;
                if (power == -1)
                    return 1 / (double)b;
                else if (power > 0)
                {
                    if (IsEven(power))
                        return Power((double)b * b, power << 1);
                    else
                        return Power((double)b * b, (power - 1) << 1);
                }
                else // if (power < 0)
                    return Power(1 / (double)b, -power);
            }
            else
            {
                if (power > 0)
                    return 0;
                else if (power < 0)
                    throw new DivideByZeroException("Cannot divide by zero. Elevating zero to a negative power is equal to dividing by zero raised to the absolute value of the power.");
                else
                    throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static double Power(short b, int power)
        {
            if (b != 0)
            {
                if (power == 0)
                    return 1;
                else if (power == 1)
                    return b;
                if (power == -1)
                    return 1 / (double)b;
                else if (power > 0)
                {
                    if (IsEven(power))
                        return Power((double)b * b, power << 1);
                    else
                        return Power((double)b * b, (power - 1) << 1);
                }
                else // if (power < 0)
                    return Power(1 / (double)b, -power);
            }
            else
            {
                if (power > 0)
                    return 0;
                else if (power < 0)
                    throw new DivideByZeroException("Cannot divide by zero. Elevating zero to a negative power is equal to dividing by zero raised to the absolute value of the power.");
                else
                    throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static double Power(int b, int power)
        {
            if (b != 0)
            {
                if (power == 0)
                    return 1;
                else if (power == 1)
                    return b;
                if (power == -1)
                    return 1 / (double)b;
                else if (power > 0)
                {
                    if (IsEven(power))
                        return Power((double)b * b, power << 1);
                    else
                        return Power((double)b * b, (power - 1) << 1);
                }
                else // if (power < 0)
                    return Power(1 / (double)b, -power);
            }
            else
            {
                if (power > 0)
                    return 0;
                else if (power < 0)
                    throw new DivideByZeroException("Cannot divide by zero. Elevating zero to a negative power is equal to dividing by zero raised to the absolute value of the power.");
                else
                    throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static double Power(long b, int power)
        {
            if (b != 0)
            {
                if (power == 0)
                    return 1;
                else if (power == 1)
                    return b;
                if (power == -1)
                    return 1 / (double)b;
                else if (power > 0)
                {
                    if (IsEven(power))
                        return Power((double)b * b, power << 1);
                    else
                        return Power((double)b * b, (power - 1) << 1);
                }
                else // if (power < 0)
                    return Power(1 / (double)b, -power);
            }
            else
            {
                if (power > 0)
                    return 0;
                else if (power < 0)
                    throw new DivideByZeroException("Cannot divide by zero. Elevating zero to a negative power is equal to dividing by zero raised to the absolute value of the power.");
                else
                    throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static double Power(sbyte b, int power)
        {
            if (b != 0)
            {
                if (power == 0)
                    return 1;
                else if (power == 1)
                    return b;
                if (power == -1)
                    return 1 / (double)b;
                else if (power > 0)
                {
                    if (IsEven(power))
                        return Power((double)b * b, power << 1);
                    else
                        return Power((double)b * b, (power - 1) << 1);
                }
                else // if (power < 0)
                    return Power(1 / (double)b, -power);
            }
            else
            {
                if (power > 0)
                    return 0;
                else if (power < 0)
                    throw new DivideByZeroException("Cannot divide by zero. Elevating zero to a negative power is equal to dividing by zero raised to the absolute value of the power.");
                else
                    throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static double Power(ushort b, int power)
        {
            if (b != 0)
            {
                if (power == 0)
                    return 1;
                else if (power == 1)
                    return b;
                if (power == -1)
                    return 1 / (double)b;
                else if (power > 0)
                {
                    if (IsEven(power))
                        return Power((double)b * b, power << 1);
                    else
                        return Power((double)b * b, (power - 1) << 1);
                }
                else // if (power < 0)
                    return Power(1 / (double)b, -power);
            }
            else
            {
                if (power > 0)
                    return 0;
                else if (power < 0)
                    throw new DivideByZeroException("Cannot divide by zero. Elevating zero to a negative power is equal to dividing by zero raised to the absolute value of the power.");
                else
                    throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static double Power(uint b, int power)
        {
            if (b != 0)
            {
                if (power == 0)
                    return 1;
                else if (power == 1)
                    return b;
                if (power == -1)
                    return 1 / (double)b;
                else if (power > 0)
                {
                    if (IsEven(power))
                        return Power((double)b * b, power << 1);
                    else
                        return Power((double)b * b, (power - 1) << 1);
                }
                else // if (power < 0)
                    return Power(1 / (double)b, -power);
            }
            else
            {
                if (power > 0)
                    return 0;
                else if (power < 0)
                    throw new DivideByZeroException("Cannot divide by zero. Elevating zero to a negative power is equal to dividing by zero raised to the absolute value of the power.");
                else
                    throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static double Power(ulong b, int power)
        {
            if (b != 0)
            {
                if (power == 0)
                    return 1;
                else if (power == 1)
                    return b;
                if (power == -1)
                    return 1 / (double)b;
                else if (power > 0)
                {
                    if (IsEven(power))
                        return Power((double)b * b, power << 1);
                    else
                        return Power((double)b * b, (power - 1) << 1);
                }
                else // if (power < 0)
                    return Power(1 / (double)b, -power);
            }
            else
            {
                if (power > 0)
                    return 0;
                else if (power < 0)
                    throw new DivideByZeroException("Cannot divide by zero. Elevating zero to a negative power is equal to dividing by zero raised to the absolute value of the power.");
                else
                    throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static double Power(float b, int power)
        {
            if (b != 0)
            {
                if (power == 0)
                    return 1;
                else if (power == 1)
                    return b;
                if (power == -1)
                    return 1 / (double)b;
                else if (power > 0)
                {
                    if (IsEven(power))
                        return Power((double)b * b, power << 1);
                    else
                        return Power((double)b * b, (power - 1) << 1);
                }
                else // if (power < 0)
                    return Power(1 / (double)b, -power);
            }
            else
            {
                if (power > 0)
                    return 0;
                else if (power < 0)
                    throw new DivideByZeroException("Cannot divide by zero. Elevating zero to a negative power is equal to dividing by zero raised to the absolute value of the power.");
                else
                    throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static double Power(double b, int power)
        {
            if (b != 0)
            {
                if (power == 0)
                    return 1;
                else if (power == 1)
                    return b;
                if (power == -1)
                    return 1 / b;
                else if (power > 0)
                {
                    if (IsEven(power))
                        return Power(b * b, power << 1);
                    else
                        return Power(b * b, (power - 1) << 1);
                }
                else // if (power < 0)
                    return Power(1 / b, -power);
            }
            else
            {
                if (power > 0)
                    return 0;
                else if (power < 0)
                    throw new DivideByZeroException("Cannot divide by zero. Elevating zero to a negative power is equal to dividing by zero raised to the absolute value of the power.");
                else
                    throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static double Power(decimal b, int power)
        {
            if (b != 0)
            {
                if (power == 0)
                    return 1;
                else if (power == 1)
                    return (double)b;
                if (power == -1)
                    return 1 / (double)b;
                else if (power > 0)
                {
                    if (IsEven(power))
                        return Power((double)b * (double)b, power << 1);
                    else
                        return Power((double)b * (double)b, (power - 1) << 1);
                }
                else // if (power < 0)
                    return Power(1 / (double)b, -power);
            }
            else
            {
                if (power > 0)
                    return 0;
                else if (power < 0)
                    throw new DivideByZeroException("Cannot divide by zero. Elevating zero to a negative power is equal to dividing by zero raised to the absolute value of the power.");
                else
                    throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static double Power(float b, float power) => Exponentation(power * Ln(b));
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static double Power(double b, double power) => Exponentation(power * Ln(b));
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static double Power(decimal b, decimal power) => Exponentation(power * (decimal)Ln(b));
        #endregion
        #region Factorial
        /// <summary>Returns the factorial of a number.</summary>
        /// <param name="b">The base number to get the factorial of.</param>
        public static double Factorial(byte b)
        {
            if (b == 0) return 1;
            else // Always positive; byte ranges from 0 to 255
            {
                double result = 1;
                for (byte i = 2; i <= b; i++)
                    result *= i;
                return result;
            }
        }
        /// <summary>Returns the factorial of a number.</summary>
        /// <param name="b">The base number to get the factorial of.</param>
        public static double Factorial(short b)
        {
            if (b == 0) return 1;
            else if (b > 0)
            {
                double result = 1;
                for (short i = 2; i <= b; i++)
                    result *= i;
                return result;
            }
            else throw new NegativeNumberFactorialException();
        }
        /// <summary>Returns the factorial of a number.</summary>
        /// <param name="b">The base number to get the factorial of.</param>
        public static double Factorial(int b)
        {
            if (b == 0) return 1;
            else if (b > 0)
            {
                double result = 1;
                for (int i = 2; i <= b; i++)
                    result *= i;
                return result;
            }
            else throw new NegativeNumberFactorialException();
        }
        /// <summary>Returns the factorial of a number.</summary>
        /// <param name="b">The base number to get the factorial of.</param>
        public static double Factorial(long b)
        {
            if (b == 0) return 1;
            else if (b > 0)
            {
                double result = 1;
                for (long i = 2; i <= b; i++)
                    result *= i;
                return result;
            }
            else throw new NegativeNumberFactorialException();
        }
        /// <summary>Returns the factorial of a number.</summary>
        /// <param name="b">The base number to get the factorial of.</param>
        public static double Factorial(sbyte b)
        {
            if (b == 0) return 1;
            else if (b > 0)
            {
                double result = 1;
                for (sbyte i = 2; i <= b; i++)
                    result *= i;
                return result;
            }
            else throw new NegativeNumberFactorialException();
        }
        /// <summary>Returns the factorial of a number.</summary>
        /// <param name="b">The base number to get the factorial of.</param>
        public static double Factorial(ushort b)
        {
            if (b == 0) return 1;
            else // Unsigned, always positive
            {
                double result = 1;
                for (ushort i = 2; i <= b; i++)
                    result *= i;
                return result;
            }
        }
        /// <summary>Returns the factorial of a number.</summary>
        /// <param name="b">The base number to get the factorial of.</param>
        public static double Factorial(uint b)
        {
            if (b == 0) return 1;
            else // Unsigned, always positive
            {
                double result = 1;
                for (uint i = 2; i <= b; i++)
                    result *= i;
                return result;
            }
        }
        /// <summary>Returns the factorial of a number.</summary>
        /// <param name="b">The base number to get the factorial of.</param>
        public static double Factorial(ulong b)
        {
            if (b == 0) return 1;
            else // Unsigned, always positive
            {
                double result = 1;
                for (ulong i = 2; i <= b; i++)
                    result *= i;
                return result;
            }
        }
        #endregion
        #region Factorization
        /// <summary>Returns the factorization of two numbers.</summary>
        /// <param name="start">The starting number to get the factorization of.</param>
        /// <param name="end">The ending number to get the factorization of.</param>
        public static double Factorization(byte start, byte end)
        {
            if (start < end)
            {
                double result = 1;
                for (byte i = start; i <= end; i++)
                    result *= i;
                return result;
            }
            else if (start == end) return 1;
            else throw new InvalidFactorizationVariableOrderException();
        }
        /// <summary>Returns the factorization of two numbers.</summary>
        /// <param name="start">The starting number to get the factorization of.</param>
        /// <param name="end">The ending number to get the factorization of.</param>
        public static double Factorization(short start, short end)
        {
            if (start < end)
            {
                if (start >= 0 && end >= 0)
                {
                    double result = 1;
                    for (short i = start; i <= end; i++)
                        result *= i;
                    return result;
                }
                else throw new NegativeNumberFactorialException();
            }
            else if (start == end) return 1;
            else throw new InvalidFactorizationVariableOrderException();
        }
        /// <summary>Returns the factorization of two numbers.</summary>
        /// <param name="start">The starting number to get the factorization of.</param>
        /// <param name="end">The ending number to get the factorization of.</param>
        public static double Factorization(int start, int end)
        {
            if (start < end)
            {
                if (start >= 0 && end >= 0)
                {
                    double result = 1;
                    for (int i = start; i <= end; i++)
                        result *= i;
                    return result;
                }
                else throw new NegativeNumberFactorialException();
            }
            else if (start == end) return 1;
            else throw new InvalidFactorizationVariableOrderException();
        }
        /// <summary>Returns the factorization of two numbers.</summary>
        /// <param name="start">The starting number to get the factorization of.</param>
        /// <param name="end">The ending number to get the factorization of.</param>
        public static double Factorization(long start, long end)
        {
            if (start < end)
            {
                if (start >= 0 && end >= 0)
                {
                    double result = 1;
                    for (long i = start; i <= end; i++)
                        result *= i;
                    return result;
                }
                else throw new NegativeNumberFactorialException();
            }
            else if (start == end) return 1;
            else throw new InvalidFactorizationVariableOrderException();
        }
        /// <summary>Returns the factorization of two numbers.</summary>
        /// <param name="start">The starting number to get the factorization of.</param>
        /// <param name="end">The ending number to get the factorization of.</param>
        public static double Factorization(sbyte start, sbyte end)
        {
            if (start < end)
            {
                if (start >= 0 && end >= 0)
                {
                    double result = 1;
                    for (sbyte i = start; i <= end; i++)
                        result *= i;
                    return result;
                }
                else throw new NegativeNumberFactorialException();
            }
            else if (start == end) return 1;
            else throw new InvalidFactorizationVariableOrderException();
        }
        /// <summary>Returns the factorization of two numbers.</summary>
        /// <param name="start">The starting number to get the factorization of.</param>
        /// <param name="end">The ending number to get the factorization of.</param>
        public static double Factorization(ushort start, ushort end)
        {
            if (start < end)
            {
                double result = 1;
                for (ushort i = start; i <= end; i++)
                    result *= i;
                return result;
            }
            else if (start == end) return 1;
            else throw new InvalidFactorizationVariableOrderException();
        }
        /// <summary>Returns the factorization of two numbers.</summary>
        /// <param name="start">The starting number to get the factorization of.</param>
        /// <param name="end">The ending number to get the factorization of.</param>
        public static double Factorization(uint start, uint end)
        {
            if (start < end)
            {
                double result = 1;
                for (uint i = start; i <= end; i++)
                    result *= i;
                return result;
            }
            else if (start == end) return 1;
            else throw new InvalidFactorizationVariableOrderException();
        }
        /// <summary>Returns the factorization of two numbers.</summary>
        /// <param name="start">The starting number to get the factorization of.</param>
        /// <param name="end">The ending number to get the factorization of.</param>
        public static double Factorization(ulong start, ulong end)
        {
            if (start < end)
            {
                double result = 1;
                for (ulong i = start; i <= end; i++)
                    result *= i;
                return result;
            }
            else if (start == end) return 1;
            else throw new InvalidFactorizationVariableOrderException();
        }
        #endregion
        #region Root
        /// <summary>Returns the root of a number.</summary>
        /// <param name="b">The base number to get the root of.</param>
        /// <param name="rootClass">The class of the root.</param>
        public static decimal Root(byte b, int rootClass)
        {
            if (b == 0 || b == 1) return b;
            else if (b > 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 3; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return middle;
            }
            else // if (0 < b < 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 3; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return middle;
            }
        }
        /// <summary>Returns the root of a number.</summary>
        /// <param name="b">The base number to get the root of.</param>
        /// <param name="rootClass">The class of the root.</param>
        public static decimal Root(short b, int rootClass)
        {
            bool negative = b < 0;
            if (negative) b = (short)-b; // Already checked if it's a negative number, needless to work around with the stupid negative sign
            if (b == 0 || b == 1) return b;
            else if (((rootClass & 1) == 0) && negative) throw new Exception(); // EvenClassRootOfNegativeNumberException
            else if (b > 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 5; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return negative ? -middle : middle;
            }
            else // if (0 < b < 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 5; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return negative ? -middle : middle;
            }
        }
        /// <summary>Returns the root of a number.</summary>
        /// <param name="b">The base number to get the root of.</param>
        /// <param name="rootClass">The class of the root.</param>
        public static decimal Root(int b, int rootClass)
        {
            bool negative = b < 0;
            if (negative) b = -b; // Already checked if it's a negative number, needless to work around with the stupid negative sign
            if (b == 0 || b == 1) return b;
            else if (((rootClass & 1) == 0) && negative) throw new Exception(); // EvenClassRootOfNegativeNumberException
            else if (b > 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 10; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return negative ? -middle : middle;
            }
            else // if (0 < b < 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 10; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return negative ? -middle : middle;
            }
        }
        /// <summary>Returns the root of a number.</summary>
        /// <param name="b">The base number to get the root of.</param>
        /// <param name="rootClass">The class of the root.</param>
        public static decimal Root(long b, int rootClass)
        {
            bool negative = b < 0;
            if (negative) b = -b; // Already checked if it's a negative number, needless to work around with the stupid negative sign
            if (b == 0 || b == 1) return b;
            else if (((rootClass & 1) == 0) && negative) throw new Exception(); // EvenClassRootOfNegativeNumberException
            else if (b > 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 19; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return negative ? -middle : middle;
            }
            else // if (0 < b < 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 19; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return negative ? -middle : middle;
            }
        }
        /// <summary>Returns the root of a number.</summary>
        /// <param name="b">The base number to get the root of.</param>
        /// <param name="rootClass">The class of the root.</param>
        public static decimal Root(sbyte b, int rootClass)
        {
            bool negative = b < 0;
            if (negative) b = (sbyte)-b; // Already checked if it's a negative number, needless to work around with the stupid negative sign
            if (b == 0 || b == 1) return b;
            else if (((rootClass & 1) == 0) && negative) throw new Exception(); // EvenClassRootOfNegativeNumberException
            else if (b > 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 3; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return negative ? -middle : middle;
            }
            else // if (0 < b < 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 3; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return negative ? -middle : middle;
            }
        }
        /// <summary>Returns the root of a number.</summary>
        /// <param name="b">The base number to get the root of.</param>
        /// <param name="rootClass">The class of the root.</param>
        public static decimal Root(ushort b, int rootClass)
        {
            if (b == 0 || b == 1) return b;
            else if (b > 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 5; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return middle;
            }
            else // if (0 < b < 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 5; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return middle;
            }
        }
        /// <summary>Returns the root of a number.</summary>
        /// <param name="b">The base number to get the root of.</param>
        /// <param name="rootClass">The class of the root.</param>
        public static decimal Root(uint b, int rootClass)
        {
            if (b == 0 || b == 1) return b;
            else if (b > 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 10; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return middle;
            }
            else // if (0 < b < 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 10; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return middle;
            }
        }
        /// <summary>Returns the root of a number.</summary>
        /// <param name="b">The base number to get the root of.</param>
        /// <param name="rootClass">The class of the root.</param>
        public static decimal Root(ulong b, int rootClass)
        {
            if (b == 0 || b == 1) return b;
            else if (b > 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 19; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return middle;
            }
            else // if (0 < b < 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 19; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return middle;
            }
        }
        /// <summary>Returns the root of b number.</summary>
        /// <param name="b">The base number to get the root of.</param>
        /// <param name="rootClass">The class of the root.</param>
        public static double Root(float b, int rootClass)
        {
            if (b == 0 || b == 1) return b;
            else if (b > 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 38; // Maximum digit count
                double start = Power(10, (minRootCount - 1));
                double end = Power(10, maxRootCount) - 1;
                double middle = (start + end) / 2;
                double power;
                while ((power = Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return middle;
            }
            else // if (0 < b < 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 38; // Maximum digit count
                double start = Power(10, (minRootCount - 1));
                double end = Power(10, maxRootCount) - 1;
                double middle = (start + end) / 2;
                double power;
                while ((power = Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return middle;
            }
        }
        /// <summary>Returns the root of b number.</summary>
        /// <param name="b">The base number to get the root of.</param>
        /// <param name="rootClass">The class of the root.</param>
        public static double Root(double b, int rootClass)
        {
            if (b == 0 || b == 1) return b;
            else if (b > 1)
            {
                // Decimals can't hold anythihng too big
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 324; // Maximum digit count
                double start = Power(10, (minRootCount - 1));
                double end = Power(10, maxRootCount) - 1;
                double middle = (start + end) / 2;
                double power;
                while ((power = Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return middle;
            }
            else // if (0 < b < 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 324; // Maximum digit count
                double start = Power(10, (minRootCount - 1));
                double end = Power(10, maxRootCount) - 1;
                double middle = (start + end) / 2;
                double power;
                while ((power = Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return middle;
            }
        }
        /// <summary>Returns the root of a number.</summary>
        /// <param name="b">The base number to get the root of.</param>
        /// <param name="rootClass">The class of the root.</param>
        public static decimal Root(decimal b, int rootClass)
        {
            if (b == 0 || b == 1) return b;
            else if (b > 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 324; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return middle;
            }
            else // if (0 < b < 1)
            {
                int maxRootCount = 1; // Minimum digit count
                int minRootCount = 324; // Maximum digit count
                decimal start = (decimal)Power(10, (minRootCount - 1));
                decimal end = (decimal)Power(10, maxRootCount) - 1;
                decimal middle = (start + end) / 2;
                decimal power;
                while ((power = (decimal)Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                return middle;
            }
        }
        #endregion
        #region Square Root
        /// <summary>Returns the square root of a number.</summary>
        /// <param name="b">The base number to get the square root of.</param>
        public static decimal SquareRoot(byte b) => Root(b, 2);
        /// <summary>Returns the square root of a number.</summary>
        /// <param name="b">The base number to get the square root of.</param>
        public static decimal SquareRoot(short b) => Root(b, 2);
        /// <summary>Returns the square root of a number.</summary>
        /// <param name="b">The base number to get the square root of.</param>
        public static decimal SquareRoot(int b) => Root(b, 2);
        /// <summary>Returns the square root of a number.</summary>
        /// <param name="b">The base number to get the square root of.</param>
        public static decimal SquareRoot(long b) => Root(b, 2);
        /// <summary>Returns the square root of a number.</summary>
        /// <param name="b">The base number to get the square root of.</param>
        public static decimal SquareRoot(sbyte b) => Root(b, 2);
        /// <summary>Returns the square root of a number.</summary>
        /// <param name="b">The base number to get the square root of.</param>
        public static decimal SquareRoot(ushort b) => Root(b, 2);
        /// <summary>Returns the square root of a number.</summary>
        /// <param name="b">The base number to get the square root of.</param>
        public static decimal SquareRoot(uint b) => Root(b, 2);
        /// <summary>Returns the square root of a number.</summary>
        /// <param name="b">The base number to get the square root of.</param>
        public static decimal SquareRoot(ulong b) => Root(b, 2);
        /// <summary>Returns the square root of a number.</summary>
        /// <param name="b">The base number to get the square root of.</param>
        public static double SquareRoot(float b) => Root(b, 2);
        /// <summary>Returns the square root of a number.</summary>
        /// <param name="b">The base number to get the square root of.</param>
        public static double SquareRoot(double b) => Root(b, 2);
        /// <summary>Returns the square root of a number.</summary>
        /// <param name="b">The base number to get the square root of.</param>
        public static decimal SquareRoot(decimal b) => Root(b, 2);
        #endregion
        #region Greatest Common Divisor
        /// <summary>Returns the greatest common divisor of a number of <seealso cref="byte"/> integers.</summary>
        /// <param name="l">The array of <seealso cref="byte"/> integers.</param>
        public static byte GreatestCommonDivisor(params byte[] l)
        {
            byte max = Max(l);
            byte GCD = 1;
            bool isDivisible = true;
            for (byte i = 1; i < max / 2; i++)
            {
                for (int j = 0; j < l.Length && isDivisible; j++)
                    isDivisible = l[j] % i == 0;
                if (isDivisible)
                    GCD = i;
            }
            return GCD;
        }
        /// <summary>Returns the greatest common divisor of a number of <seealso cref="short"/> integers.</summary>
        /// <param name="l">The array of <seealso cref="short"/> integers.</param>
        public static short GreatestCommonDivisor(params short[] l)
        {
            for (int i = 0; i < l.Length; i++)
                l[i] = AbsoluteValue(l[i]);
            short max = Max(l);
            short GCD = 1;
            bool isDivisible = true;
            for (short i = 1; i < max / 2; i++)
            {
                for (int j = 0; j < l.Length && isDivisible; j++)
                    isDivisible = l[j] % i == 0;
                if (isDivisible)
                    GCD = i;
            }
            return GCD;
        }
        /// <summary>Returns the greatest common divisor of a number of <seealso cref="int"/> integers.</summary>
        /// <param name="l">The array of <seealso cref="int"/> integers.</param>
        public static int GreatestCommonDivisor(params int[] l)
        {
            for (int i = 0; i < l.Length; i++)
                l[i] = AbsoluteValue(l[i]);
            int max = Max(l);
            int GCD = 1;
            bool isDivisible = true;
            for (int i = 1; i < max / 2; i++)
            {
                for (int j = 0; j < l.Length && isDivisible; j++)
                    isDivisible = l[j] % i == 0;
                if (isDivisible)
                    GCD = i;
            }
            return GCD;
        }
        /// <summary>Returns the greatest common divisor of a number of <seealso cref="long"/> integers.</summary>
        /// <param name="l">The array of <seealso cref="long"/> integers.</param>
        public static long GreatestCommonDivisor(params long[] l)
        {
            for (int i = 0; i < l.Length; i++)
                l[i] = AbsoluteValue(l[i]);
            long max = Max(l);
            long GCD = 1;
            bool isDivisible = true;
            for (long i = 1; i < max / 2; i++)
            {
                for (int j = 0; j < l.Length && isDivisible; j++)
                    isDivisible = l[j] % i == 0;
                if (isDivisible)
                    GCD = i;
            }
            return GCD;
        }
        /// <summary>Returns the greatest common divisor of a number of <seealso cref="sbyte"/> integers.</summary>
        /// <param name="l">The array of <seealso cref="sbyte"/> integers.</param>
        public static sbyte GreatestCommonDivisor(params sbyte[] l)
        {
            for (int i = 0; i < l.Length; i++)
                l[i] = AbsoluteValue(l[i]);
            sbyte max = Max(l);
            sbyte GCD = 1;
            bool isDivisible = true;
            for (sbyte i = 1; i < max / 2; i++)
            {
                for (int j = 0; j < l.Length && isDivisible; j++)
                    isDivisible = l[j] % i == 0;
                if (isDivisible)
                    GCD = i;
            }
            return GCD;
        }
        /// <summary>Returns the greatest common divisor of a number of <seealso cref="ushort"/> integers.</summary>
        /// <param name="l">The array of <seealso cref="ushort"/> integers.</param>
        public static ushort GreatestCommonDivisor(params ushort[] l)
        {
            ushort max = Max(l);
            ushort GCD = 1;
            bool isDivisible = true;
            for (ushort i = 1; i < max / 2; i++)
            {
                for (int j = 0; j < l.Length && isDivisible; j++)
                    isDivisible = l[j] % i == 0;
                if (isDivisible)
                    GCD = i;
            }
            return GCD;
        }
        /// <summary>Returns the greatest common divisor of a number of <seealso cref="uint"/> integers.</summary>
        /// <param name="l">The array of <seealso cref="uint"/> integers.</param>
        public static uint GreatestCommonDivisor(params uint[] l)
        {
            uint max = Max(l);
            uint GCD = 1;
            bool isDivisible = true;
            for (uint i = 1; i < max / 2; i++)
            {
                for (int j = 0; j < l.Length && isDivisible; j++)
                    isDivisible = l[j] % i == 0;
                if (isDivisible)
                    GCD = i;
            }
            return GCD;
        }
        /// <summary>Returns the greatest common divisor of a number of <seealso cref="ulong"/> integers.</summary>
        /// <param name="l">The array of <seealso cref="ulong"/> integers.</param>
        public static ulong GreatestCommonDivisor(params ulong[] l)
        {
            ulong max = Max(l);
            ulong GCD = 1;
            bool isDivisible = true;
            for (ulong i = 1; i < max / 2; i++)
            {
                for (int j = 0; j < l.Length && isDivisible; j++)
                    isDivisible = l[j] % i == 0;
                if (isDivisible)
                    GCD = i;
            }
            return GCD;
        }
        #endregion
        #region Least Common Multiple
        /// <summary>Returns the least common multiple of a number of <seealso cref="byte"/> integers.</summary>
        /// <param name="l">The array of <seealso cref="byte"/> integers.</param>
        public static short LeastCommonMultiple(params byte[] l)
        {
            byte max = Max(l);
            short LCM = 0;
            bool isMultiple = false;
            while (!isMultiple)
            {
                LCM += max;
                isMultiple = true;
                for (int i = 0; i < l.Length && isMultiple; i++)
                    isMultiple = LCM % l[i] == 0;
            }
            return LCM;
        }
        /// <summary>Returns the least common multiple of a number of <seealso cref="short"/> integers.</summary>
        /// <param name="l">The array of <seealso cref="short"/> integers.</param>
        public static int LeastCommonMultiple(params short[] l)
        {
            for (int i = 0; i < l.Length; i++)
                l[i] = AbsoluteValue(l[i]);
            short max = Max(l);
            int LCM = 0;
            bool isMultiple = false;
            while (!isMultiple)
            {
                LCM += max;
                isMultiple = true;
                for (int i = 0; i < l.Length && isMultiple; i++)
                    isMultiple = LCM % l[i] == 0;
            }
            return LCM;
        }
        /// <summary>Returns the least common multiple of a number of <seealso cref="int"/> integers.</summary>
        /// <param name="l">The array of <seealso cref="int"/> integers.</param>
        public static long LeastCommonMultiple(params int[] l)
        {
            for (int i = 0; i < l.Length; i++)
                l[i] = AbsoluteValue(l[i]);
            int max = Max(l);
            long LCM = 0;
            bool isMultiple = false;
            while (!isMultiple)
            {
                LCM += max;
                isMultiple = true;
                for (int i = 0; i < l.Length && isMultiple; i++)
                    isMultiple = LCM % l[i] == 0;
            }
            return LCM;
        }
        /// <summary>Returns the least common multiple of a number of <seealso cref="long"/> integers.</summary>
        /// <param name="l">The array of <seealso cref="long"/> integers.</param>
        public static long LeastCommonMultiple(params long[] l)
        {
            for (int i = 0; i < l.Length; i++)
                l[i] = AbsoluteValue(l[i]);
            long max = Max(l);
            long LCM = 0;
            bool isMultiple = false;
            while (!isMultiple)
            {
                LCM += max;
                isMultiple = true;
                for (int i = 0; i < l.Length && isMultiple; i++)
                    isMultiple = LCM % l[i] == 0;
            }
            return LCM;
        }
        /// <summary>Returns the least common multiple of a number of <seealso cref="sbyte"/> integers.</summary>
        /// <param name="l">The array of <seealso cref="sbyte"/> integers.</param>
        public static short LeastCommonMultiple(params sbyte[] l)
        {
            for (int i = 0; i < l.Length; i++)
                l[i] = AbsoluteValue(l[i]);
            sbyte max = Max(l);
            short LCM = 0;
            bool isMultiple = false;
            while (!isMultiple)
            {
                LCM += max;
                isMultiple = true;
                for (int i = 0; i < l.Length && isMultiple; i++)
                    isMultiple = LCM % l[i] == 0;
            }
            return LCM;
        }
        /// <summary>Returns the least common multiple of a number of <seealso cref="ushort"/> integers.</summary>
        /// <param name="l">The array of <seealso cref="ushort"/> integers.</param>
        public static uint LeastCommonMultiple(params ushort[] l)
        {
            ushort max = Max(l);
            uint LCM = 0;
            bool isMultiple = false;
            while (!isMultiple)
            {
                LCM += max;
                isMultiple = true;
                for (int i = 0; i < l.Length && isMultiple; i++)
                    isMultiple = LCM % l[i] == 0;
            }
            return LCM;
        }
        /// <summary>Returns the least common multiple of a number of <seealso cref="uint"/> integers.</summary>
        /// <param name="l">The array of <seealso cref="uint"/> integers.</param>
        public static ulong LeastCommonMultiple(params uint[] l)
        {
            uint max = Max(l);
            ulong LCM = 0;
            bool isMultiple = false;
            while (!isMultiple)
            {
                LCM += max;
                isMultiple = true;
                for (int i = 0; i < l.Length && isMultiple; i++)
                    isMultiple = LCM % l[i] == 0;
            }
            return LCM;
        }
        /// <summary>Returns the least common multiple of a number of <seealso cref="ulong"/> integers.</summary>
        /// <param name="l">The array of <seealso cref="ulong"/> integers.</param>
        public static ulong LeastCommonMultiple(params ulong[] l)
        {
            ulong max = Max(l);
            ulong LCM = 0;
            bool isMultiple = false;
            while (!isMultiple)
            {
                LCM += max;
                isMultiple = true;
                for (int i = 0; i < l.Length && isMultiple; i++)
                    isMultiple = LCM % l[i] == 0;
            }
            return LCM;
        }
        #endregion
        #region Sum
        /// <summary>Returns the sum of a number of <seealso cref="byte"/> integers.</summary>
        /// <param name="a">The array of <seealso cref="byte"/> integers to calculate the sum of.</param>
        public static long Sum(params byte[] a)
        {
            long result = 0;
            for (int i = 0; i < a.Length; i++)
                result += a[i];
            return result;
        }
        /// <summary>Returns the sum of a number of <seealso cref="short"/> integers.</summary>
        /// <param name="a">The array of <seealso cref="short"/> integers to calculate the sum of.</param>
        public static long Sum(params short[] a)
        {
            long result = 0;
            for (int i = 0; i < a.Length; i++)
                result += a[i];
            return result;
        }
        /// <summary>Returns the sum of a number of <seealso cref="int"/> integers.</summary>
        /// <param name="a">The array of <seealso cref="int"/> integers to calculate the sum of.</param>
        public static long Sum(params int[] a)
        {
            long result = 0;
            for (int i = 0; i < a.Length; i++)
                result += a[i];
            return result;
        }
        /// <summary>Returns the sum of a number of <seealso cref="long"/> integers.</summary>
        /// <param name="a">The array of <seealso cref="long"/> integers to calculate the sum of.</param>
        public static decimal Sum(params long[] a)
        {
            decimal result = 0; 
            for (int i = 0; i < a.Length; i++)
                result += a[i];
            return result;
        }
        /// <summary>Returns the sum of a number of <seealso cref="sbyte"/> integers.</summary>
        /// <param name="a">The array of <seealso cref="sbyte"/> integers to calculate the sum of.</param>
        public static long Sum(params sbyte[] a)
        {
            long result = 0;
            for (int i = 0; i < a.Length; i++)
                result += a[i];
            return result;
        }
        /// <summary>Returns the sum of a number of <seealso cref="ushort"/> integers.</summary>
        /// <param name="a">The array of <seealso cref="ushort"/> integers to calculate the sum of.</param>
        public static long Sum(params ushort[] a)
        {
            long result = 0;
            for (int i = 0; i < a.Length; i++)
                result += a[i];
            return result;
        }
        /// <summary>Returns the sum of a number of <seealso cref="uint"/> integers.</summary>
        /// <param name="a">The array of <seealso cref="uint"/> integers to calculate the sum of.</param>
        public static long Sum(params uint[] a)
        {
            long result = 0;
            for (int i = 0; i < a.Length; i++)
                result += a[i];
            return result;
        }
        /// <summary>Returns the sum of a number of <seealso cref="ulong"/> integers.</summary>
        /// <param name="a">The array of <seealso cref="ulong"/> integers to calculate the sum of.</param>
        public static decimal Sum(params ulong[] a)
        {
            decimal result = 0;
            for (int i = 0; i < a.Length; i++)
                result += a[i];
            return result;
        }
        /// <summary>Returns the sum of a number of <seealso cref="float"/> numbers.</summary>
        /// <param name="a">The array of <seealso cref="float"/> numbers to calculate the sum of.</param>
        public static double Sum(params float[] a)
        {
            double result = 0;
            for (int i = 0; i < a.Length; i++)
                result += a[i];
            return result;
        }
        /// <summary>Returns the sum of a number of <seealso cref="double"/> numbers.</summary>
        /// <param name="a">The array of <seealso cref="double"/> numbers to calculate the sum of.</param>
        public static double Sum(params double[] a)
        {
            double result = 0;
            for (int i = 0; i < a.Length; i++)
                result += a[i];
            return result;
        }
        /// <summary>Returns the sum of a number of <seealso cref="decimal"/> numbers.</summary>
        /// <param name="a">The array of <seealso cref="decimal"/> numbers to calculate the sum of.</param>
        public static double Sum(params decimal[] a)
        {
            double result = 0;
            for (int i = 0; i < a.Length; i++)
                result += (double)a[i];
            return result;
        }
        #endregion
        #region Average
        /// <summary>Returns the avergae of a number of <seealso cref="byte"/> integers.</summary>
        /// <param name="a">The array of <seealso cref="byte"/> integers to calculate the average of.</param>
        public static double Average(params byte[] a) => Sum(a) / a.Length;
        /// <summary>Returns the avergae of a number of <seealso cref="short"/> integers.</summary>
        /// <param name="a">The array of <seealso cref="short"/> integers to calculate the average of.</param>
        public static double Average(params short[] a) => Sum(a) / a.Length;
        /// <summary>Returns the avergae of a number of <seealso cref="int"/> integers.</summary>
        /// <param name="a">The array of <seealso cref="int"/> integers to calculate the average of.</param>
        public static double Average(params int[] a) => Sum(a) / a.Length;
        /// <summary>Returns the avergae of a number of <seealso cref="long"/> integers.</summary>
        /// <param name="a">The array of <seealso cref="long"/> integers to calculate the average of.</param>
        public static double Average(params long[] a) => (double)Sum(a) / a.Length;
        /// <summary>Returns the avergae of a number of <seealso cref="sbyte"/> integers.</summary>
        /// <param name="a">The array of <seealso cref="sbyte"/> integers to calculate the average of.</param>
        public static double Average(params sbyte[] a) => Sum(a) / a.Length;
        /// <summary>Returns the avergae of a number of <seealso cref="ushort"/> integers.</summary>
        /// <param name="a">The array of <seealso cref="ushort"/> integers to calculate the average of.</param>
        public static double Average(params ushort[] a) => Sum(a) / a.Length;
        /// <summary>Returns the avergae of a number of <seealso cref="uint"/> integers.</summary>
        /// <param name="a">The array of <seealso cref="uint"/> integers to calculate the average of.</param>
        public static double Average(params uint[] a) => Sum(a) / a.Length;
        /// <summary>Returns the avergae of a number of <seealso cref="ulong"/> integers.</summary>
        /// <param name="a">The array of <seealso cref="ulong"/> integers to calculate the average of.</param>
        public static double Average(params ulong[] a) => (double)Sum(a) / a.Length;
        /// <summary>Returns the avergae of a number of <seealso cref="float"/> numbers.</summary>
        /// <param name="a">The array of <seealso cref="float"/> numbers to calculate the average of.</param>
        public static double Average(params float[] a) => Sum(a) / a.Length;
        /// <summary>Returns the avergae of a number of <seealso cref="double"/> numbers.</summary>
        /// <param name="a">The array of <seealso cref="double"/> numbers to calculate the average of.</param>
        public static double Average(params double[] a) => Sum(a) / a.Length;
        /// <summary>Returns the avergae of a number of <seealso cref="decimal"/> numbers.</summary>
        /// <param name="a">The array of <seealso cref="decimal"/> numbers to calculate the average of.</param>
        public static double Average(params decimal[] a) => Sum(a) / a.Length;
        #endregion
        #region Is Prime
        /// <summary>Checks if a number is a prime or not.</summary>
        /// <param name="n">The number to check if it's a prime or not.</param>
        public static bool IsPrime(byte n)
        {
            if (n == 0 || n == 1) return false;
            else if (n == 2) return true;
            else
            {
                List<byte> primesFound = new List<byte> { 1, 2 };
                bool isPrime = true;
                for (byte p = 3; p <= n; p++)
                {
                    for (int i = 0; i < primesFound.Count && isPrime; i++)
                        isPrime = p % primesFound[i] != 0;
                    if (isPrime)
                        primesFound.Add(p);
                }
                return isPrime;
            }
        }
        /// <summary>Checks if a number is a prime or not.</summary>
        /// <param name="n">The number to check if it's a prime or not.</param>
        public static bool IsPrime(short n)
        {
            n = AbsoluteValue(n);
            if (n == 0 || n == 1) return false;
            else if (n == 2) return true;
            else
            {
                List<short> primesFound = new List<short> { 1, 2 };
                bool isPrime = true;
                for (short p = 3; p <= n; p++)
                {
                    for (int i = 0; i < primesFound.Count && isPrime; i++)
                        isPrime = p % primesFound[i] != 0;
                    if (isPrime)
                        primesFound.Add(p);
                }
                return isPrime;
            }
        }
        /// <summary>Checks if a number is a prime or not.</summary>
        /// <param name="n">The number to check if it's a prime or not.</param>
        public static bool IsPrime(int n)
        {
            n = AbsoluteValue(n);
            if (n == 0 || n == 1) return false;
            else if (n == 2) return true;
            else
            {
                List<int> primesFound = new List<int> { 1, 2 };
                bool isPrime = true;
                for (int p = 3; p <= n; p++)
                {
                    for (int i = 0; i < primesFound.Count && isPrime; i++)
                        isPrime = p % primesFound[i] != 0;
                    if (isPrime)
                        primesFound.Add(p);
                }
                return isPrime;
            }
        }
        /// <summary>Checks if a number is a prime or not.</summary>
        /// <param name="n">The number to check if it's a prime or not.</param>
        public static bool IsPrime(long n)
        {
            n = AbsoluteValue(n);
            if (n == 0 || n == 1) return false;
            else if (n == 2) return true;
            else
            {
                List<long> primesFound = new List<long> { 1, 2 };
                bool isPrime = true;
                for (long p = 3; p <= n; p++)
                {
                    for (int i = 0; i < primesFound.Count && isPrime; i++)
                        isPrime = p % primesFound[i] != 0;
                    if (isPrime)
                        primesFound.Add(p);
                }
                return isPrime;
            }
        }
        /// <summary>Checks if a number is a prime or not.</summary>
        /// <param name="n">The number to check if it's a prime or not.</param>
        public static bool IsPrime(sbyte n)
        {
            n = AbsoluteValue(n);
            if (n == 0 || n == 1) return false;
            else if (n == 2) return true;
            else
            {
                List<sbyte> primesFound = new List<sbyte> { 1, 2 };
                bool isPrime = true;
                for (sbyte p = 3; p <= n; p++)
                {
                    for (int i = 0; i < primesFound.Count && isPrime; i++)
                        isPrime = p % primesFound[i] != 0;
                    if (isPrime)
                        primesFound.Add(p);
                }
                return isPrime;
            }
        }
        /// <summary>Checks if a number is a prime or not.</summary>
        /// <param name="n">The number to check if it's a prime or not.</param>
        public static bool IsPrime(ushort n)
        {
            if (n == 0 || n == 1) return false;
            else if (n == 2) return true;
            else
            {
                List<ushort> primesFound = new List<ushort> { 1, 2 };
                bool isPrime = true;
                for (ushort p = 3; p <= n; p++)
                {
                    for (int i = 0; i < primesFound.Count && isPrime; i++)
                        isPrime = p % primesFound[i] != 0;
                    if (isPrime)
                        primesFound.Add(p);
                }
                return isPrime;
            }
        }
        /// <summary>Checks if a number is a prime or not.</summary>
        /// <param name="n">The number to check if it's a prime or not.</param>
        public static bool IsPrime(uint n)
        {
            if (n == 0 || n == 1) return false;
            else if (n == 2) return true;
            else
            {
                List<uint> primesFound = new List<uint> { 1, 2 };
                bool isPrime = true;
                for (uint p = 3; p <= n; p++)
                {
                    for (int i = 0; i < primesFound.Count && isPrime; i++)
                        isPrime = p % primesFound[i] != 0;
                    if (isPrime)
                        primesFound.Add(p);
                }
                return isPrime;
            }
        }
        /// <summary>Checks if a number is a prime or not.</summary>
        /// <param name="n">The number to check if it's a prime or not.</param>
        public static bool IsPrime(ulong n)
        {
            if (n == 0 || n == 1) return false;
            else if (n == 2) return true;
            else
            {
                List<ulong> primesFound = new List<ulong> { 1, 2 };
                bool isPrime = true;
                for (ulong p = 3; p <= n; p++)
                {
                    for (int i = 0; i < primesFound.Count && isPrime; i++)
                        isPrime = p % primesFound[i] != 0;
                    if (isPrime)
                        primesFound.Add(p);
                }
                return isPrime;
            }
        }
        #endregion
        #region N-th Prime
        /// <summary>Returns the n-th prime with n being an one-based index.</summary>
        /// <param name="n">The one-based index index of the prime to return.</param>
        public static long GetNthPrime(int n)
        {
            if (n <= 0) throw new ArgumentOutOfRangeException();
            else if (n == 1) return 2;
            else
            {
                List<long> primesFound = new List<long> { 1, 2 };
                bool isPrime = true;
                for (long p = 3; primesFound.Count <= n; p++)
                {
                    for (int i = 0; i < primesFound.Count && isPrime; i++)
                        isPrime = p % primesFound[i] != 0;
                    if (isPrime)
                        primesFound.Add(p);
                }
                return primesFound.Last();
            }
        }
        #endregion
        #region Is Fibonacci
        /// <summary>Checks if a number is a Fibonacci number or not.</summary>
        /// <param name="n">The number to check if it's a Fibonacci number or not.</param>
        public static bool IsFibonacci(byte n)
        {
            if (n == 0 || n == 1) return true;
            else
            {
                List<byte> fibonacciNumbers = new List<byte> { 0, 1 };
                for (int i = 2; fibonacciNumbers.Last() <= n; i++)
                    fibonacciNumbers.Add((byte)(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]));
                return fibonacciNumbers.Last() == n;
            }
        }
        /// <summary>Checks if a number is a Fibonacci number or not.</summary>
        /// <param name="n">The number to check if it's a Fibonacci number or not.</param>
        public static bool IsFibonacci(short n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException(); // Maybe NegativeFibonacciNumberCheckException?
            else if (n == 0 || n == 1) return true;
            else
            {
                List<short> fibonacciNumbers = new List<short> { 0, 1 };
                for (int i = 2; fibonacciNumbers.Last() <= n; i++)
                    fibonacciNumbers.Add((short)(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]));
                return fibonacciNumbers.Last() == n;
            }
        }
        /// <summary>Checks if a number is a Fibonacci number or not.</summary>
        /// <param name="n">The number to check if it's a Fibonacci number or not.</param>
        public static bool IsFibonacci(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException();
            else if (n == 0 || n == 1) return true;
            else
            {
                List<int> fibonacciNumbers = new List<int> { 0, 1 };
                for (int i = 2; fibonacciNumbers.Last() <= n; i++)
                    fibonacciNumbers.Add(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]);
                return fibonacciNumbers.Last() == n;
            }
        }
        /// <summary>Checks if a number is a Fibonacci number or not.</summary>
        /// <param name="n">The number to check if it's a Fibonacci number or not.</param>
        public static bool IsFibonacci(long n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException();
            else if (n == 0 || n == 1) return true;
            else
            {
                List<long> fibonacciNumbers = new List<long> { 0, 1 };
                for (int i = 2; fibonacciNumbers.Last() <= n; i++)
                    fibonacciNumbers.Add(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]);
                return fibonacciNumbers.Last() == n;
            }
        }
        /// <summary>Checks if a number is a Fibonacci number or not.</summary>
        /// <param name="n">The number to check if it's a Fibonacci number or not.</param>
        public static bool IsFibonacci(sbyte n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException();
            else if (n == 0 || n == 1) return true;
            else
            {
                List<sbyte> fibonacciNumbers = new List<sbyte> { 0, 1 };
                for (int i = 2; fibonacciNumbers.Last() <= n; i++)
                    fibonacciNumbers.Add((sbyte)(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]));
                return fibonacciNumbers.Last() == n;
            }
        }
        /// <summary>Checks if a number is a Fibonacci number or not.</summary>
        /// <param name="n">The number to check if it's a Fibonacci number or not.</param>
        public static bool IsFibonacci(ushort n)
        {
            if (n == 0 || n == 1) return true;
            else
            {
                List<ushort> fibonacciNumbers = new List<ushort> { 0, 1 };
                for (int i = 2; fibonacciNumbers.Last() <= n; i++)
                    fibonacciNumbers.Add((ushort)(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]));
                return fibonacciNumbers.Last() == n;
            }
        }
        /// <summary>Checks if a number is a Fibonacci number or not.</summary>
        /// <param name="n">The number to check if it's a Fibonacci number or not.</param>
        public static bool IsFibonacci(uint n)
        {
            if (n == 0 || n == 1) return true;
            else
            {
                List<uint> fibonacciNumbers = new List<uint> { 0, 1 };
                for (int i = 2; fibonacciNumbers.Last() <= n; i++)
                    fibonacciNumbers.Add(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]);
                return fibonacciNumbers.Last() == n;
            }
        }
        /// <summary>Checks if a number is a Fibonacci number or not.</summary>
        /// <param name="n">The number to check if it's a Fibonacci number or not.</param>
        public static bool IsFibonacci(ulong n)
        {
            if (n == 0 || n == 1) return true;
            else
            {
                List<ulong> fibonacciNumbers = new List<ulong> { 0, 1 };
                for (int i = 2; fibonacciNumbers.Last() <= n; i++)
                    fibonacciNumbers.Add(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]);
                return fibonacciNumbers.Last() == n;
            }
        }
        #endregion
        #region N-th Fibonacci
        /// <summary>Returns the n-th Fibonacci with n being an one-based index with the list starting from 0 (0, 1, 1, 2, 3, 5, ...).</summary>
        /// <param name="n">The one-based index index of the prime to return.</param>
        public static long GetNthFibonacci(int n)
        {
            if (n <= 0) throw new ArgumentOutOfRangeException();
            else if (n == 1) return 2;
            else
            {
                List<long> fibonacciNumbers = new List<long> { 0, 1 };
                for (int i = 2; fibonacciNumbers.Count <= n; i++)
                    fibonacciNumbers.Add(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]);
                return fibonacciNumbers.Last();
            }
        }
        #endregion
        #region Logarithm (base 2)
        /// <summary>Returns the binary logarithm (logarithm with base 2) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Lb(byte n)
        {
            if (n > 0) return Ln(n) / Ln(2);
            else return double.NegativeInfinity;
        }
        /// <summary>Returns the binary logarithm (logarithm with base 2) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Lb(short n)
        {
            if (n > 0) return Ln(n) / Ln(2);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base 2) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Lb(int n)
        {
            if (n > 0) return Ln(n) / Ln(2);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base 2) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Lb(long n)
        {
            if (n > 0) return Ln(n) / Ln(2);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base 2) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Lb(sbyte n)
        {
            if (n > 0) return Ln(n) / Ln(2);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base 2) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Lb(ushort n)
        {
            if (n > 0) return Ln(n) / Ln(2);
            else return double.NegativeInfinity;
        }
        /// <summary>Returns the binary logarithm (logarithm with base 2) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Lb(uint n)
        {
            if (n > 0) return Ln(n) / Ln(2);
            else return double.NegativeInfinity;
        }
        /// <summary>Returns the binary logarithm (logarithm with base 2) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Lb(ulong n)
        {
            if (n > 0) return Ln(n) / Ln(2);
            else return double.NegativeInfinity;
        }
        /// <summary>Returns the binary logarithm (logarithm with base 2) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Lb(float n)
        {
            if (n > 0) return Ln(n) / Ln(2);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base 2) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Lb(double n)
        {
            if (n > 0) return Ln(n) / Ln(2);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base 2) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Lb(decimal n)
        {
            if (n > 0) return Ln(n) / Ln(2);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        #endregion
        #region Logarithm (base e)
        /// <summary>Returns the natural logarithm (logarithm with base e) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Ln(byte n)
        {
            if (n > 0)
            {
                double t = (double)(n - 1) / (n + 1);
                double result = t;
                double previousResult = 0;
                for (int i = 3; previousResult != result; i += 2) // Don't judge me for not following the formula exactly as written on Wikipedia and adjusting some values for more efficient computation
                    result += Power(t, i) / i;
                return 2 * result;
            }
            else return double.NegativeInfinity;
        }
        /// <summary>Returns the natural logarithm (logarithm with base e) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Ln(short n)
        {
            if (n > 0)
            {
                double t = (double)(n - 1) / (n + 1);
                double result = t;
                double previousResult = 0;
                for (int i = 3; previousResult != result; i += 2)
                    result += Power(t, i) / i;
                return 2 * result;
            }
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the natural logarithm (logarithm with base e) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Ln(int n)
        {
            if (n > 0)
            {
                double t = (double)(n - 1) / (n + 1);
                double result = t;
                double previousResult = 0;
                for (int i = 3; previousResult != result; i += 2)
                    result += Power(t, i) / i;
                return 2 * result;
            }
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the natural logarithm (logarithm with base e) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Ln(long n)
        {
            if (n > 0)
            {
                double t = (double)(n - 1) / (n + 1);
                double result = t;
                double previousResult = 0;
                for (int i = 3; previousResult != result; i += 2)
                    result += Power(t, i) / i;
                return 2 * result;
            }
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the natural logarithm (logarithm with base e) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Ln(sbyte n)
        {
            if (n > 0)
            {
                double t = (double)(n - 1) / (n + 1);
                double result = t;
                double previousResult = 0;
                for (int i = 3; previousResult != result; i += 2)
                    result += Power(t, i) / i;
                return 2 * result;
            }
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the natural logarithm (logarithm with base e) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Ln(ushort n)
        {
            if (n > 0)
            {
                double t = (double)(n - 1) / (n + 1);
                double result = t;
                double previousResult = 0;
                for (int i = 3; previousResult != result; i += 2)
                    result += Power(t, i) / i;
                return 2 * result;
            }
            else return double.NegativeInfinity;
        }
        /// <summary>Returns the natural logarithm (logarithm with base e) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Ln(uint n)
        {
            if (n > 0)
            {
                double t = (double)(n - 1) / (n + 1);
                double result = t;
                double previousResult = 0;
                for (int i = 3; previousResult != result; i += 2)
                    result += Power(t, i) / i;
                return 2 * result;
            }
            else return double.NegativeInfinity;
        }
        /// <summary>Returns the natural logarithm (logarithm with base e) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Ln(ulong n)
        {
            if (n > 0)
            {
                double t = (double)(n - 1) / (n + 1);
                double result = t;
                double previousResult = 0;
                for (int i = 3; previousResult != result; i += 2)
                    result += Power(t, i) / i;
                return 2 * result;
            }
            else return double.NegativeInfinity;
        }
        /// <summary>Returns the natural logarithm (logarithm with base e) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Ln(float n)
        {
            if (n > 0)
            {
                double t = (double)(n - 1) / (n + 1);
                double result = t;
                double previousResult = 0;
                for (int i = 3; previousResult != result; i += 2)
                    result += Power(t, i) / i;
                return 2 * result;
            }
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the natural logarithm (logarithm with base e) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Ln(double n)
        {
            if (n > 0)
            {
                double t = (n - 1) / (n + 1);
                double result = t;
                double previousResult = 0;
                for (int i = 3; previousResult != result; i += 2)
                    result += Power(t, i) / i;
                return 2 * result;
            }
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the natural logarithm (logarithm with base e) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Ln(decimal n)
        {
            if (n > 0)
            {
                double t = (double)((n - 1) / (n + 1));
                double result = t;
                double previousResult = 0;
                for (int i = 3; previousResult != result; i += 2)
                    result += Power(t, i) / i;
                return 2 * result;
            }
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        #endregion
        #region Logarithm (base 10)
        /// <summary>Returns the binary logarithm (logarithm with base 10) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(byte n)
        {
            if (n > 0) return Ln(n) / Ln(10);
            else return double.NegativeInfinity;
        }
        /// <summary>Returns the binary logarithm (logarithm with base 10) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(short n)
        {
            if (n > 0) return Ln(n) / Ln(10);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base 10) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(int n)
        {
            if (n > 0) return Ln(n) / Ln(10);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base 10) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(long n)
        {
            if (n > 0) return Ln(n) / Ln(10);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base 10) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(sbyte n)
        {
            if (n > 0) return Ln(n) / Ln(10);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base 10) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(ushort n)
        {
            if (n > 0) return Ln(n) / Ln(10);
            else return double.NegativeInfinity;
        }
        /// <summary>Returns the binary logarithm (logarithm with base 10) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(uint n)
        {
            if (n > 0) return Ln(n) / Ln(10);
            else return double.NegativeInfinity;
        }
        /// <summary>Returns the binary logarithm (logarithm with base 10) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(ulong n)
        {
            if (n > 0) return Ln(n) / Ln(10);
            else return double.NegativeInfinity;
        }
        /// <summary>Returns the binary logarithm (logarithm with base 10) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(float n)
        {
            if (n > 0) return Ln(n) / Ln(10);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base 10) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(double n)
        {
            if (n > 0) return Ln(n) / Ln(10);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base 10) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(decimal n)
        {
            if (n > 0) return Ln(n) / Ln(10);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        #endregion
        #region Logarithm (base b)
        /// <summary>Returns the binary logarithm (logarithm with base b) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(byte n, double b)
        {
            if (n > 0) return Ln(n) / Ln(n);
            else return double.NegativeInfinity;
        }
        /// <summary>Returns the binary logarithm (logarithm with base b) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(short n, double b)
        {
            if (n > 0) return Ln(n) / Ln(n);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base b) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(int n, double b)
        {
            if (n > 0) return Ln(n) / Ln(n);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base b) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(long n, double b)
        {
            if (n > 0) return Ln(n) / Ln(n);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base b) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(sbyte n, double b)
        {
            if (n > 0) return Ln(n) / Ln(n);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base b) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(ushort n, double b)
        {
            if (n > 0) return Ln(n) / Ln(n);
            else return double.NegativeInfinity;
        }
        /// <summary>Returns the binary logarithm (logarithm with base b) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(uint n, double b)
        {
            if (n > 0) return Ln(n) / Ln(n);
            else return double.NegativeInfinity;
        }
        /// <summary>Returns the binary logarithm (logarithm with base b) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(ulong n, double b)
        {
            if (n > 0) return Ln(n) / Ln(n);
            else return double.NegativeInfinity;
        }
        /// <summary>Returns the binary logarithm (logarithm with base b) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(float n, double b)
        {
            if (n > 0) return Ln(n) / Ln(n);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base b) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(double n, double b)
        {
            if (n > 0) return Ln(n) / Ln(n);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base b) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static double Log(decimal n, double b)
        {
            if (n > 0) return Ln(n) / Ln(n);
            else if (n == 0) return double.NegativeInfinity;
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        #endregion
        #region Is Even
        /// <summary>Determines whether a number is even.</summary>
        /// <param name="n">The number to check whether it's even or not.</param>
        public static bool IsEven(byte n) => (n & 1) == 0;
        /// <summary>Determines whether a number is even.</summary>
        /// <param name="n">The number to check whether it's even or not.</param>
        public static bool IsEven(short n) => (n & 1) == 0;
        /// <summary>Determines whether a number is even.</summary>
        /// <param name="n">The number to check whether it's even or not.</param>
        public static bool IsEven(int n) => (n & 1) == 0;
        /// <summary>Determines whether a number is even.</summary>
        /// <param name="n">The number to check whether it's even or not.</param>
        public static bool IsEven(long n) => (n & 1) == 0;
        /// <summary>Determines whether a number is even.</summary>
        /// <param name="n">The number to check whether it's even or not.</param>
        public static bool IsEven(sbyte n) => (n & 1) == 0;
        /// <summary>Determines whether a number is even.</summary>
        /// <param name="n">The number to check whether it's even or not.</param>
        public static bool IsEven(ushort n) => (n & 1) == 0;
        /// <summary>Determines whether a number is even.</summary>
        /// <param name="n">The number to check whether it's even or not.</param>
        public static bool IsEven(uint n) => (n & 1) == 0;
        /// <summary>Determines whether a number is even.</summary>
        /// <param name="n">The number to check whether it's even or not.</param>
        public static bool IsEven(ulong n) => (n & 1) == 0;
        #endregion
        #region Is Odd
        /// <summary>Determines whether a number is odd.</summary>
        /// <param name="n">The number to check whether it's odd or not.</param>
        public static bool IsOdd(byte n) => (n & 1) == 1;
        /// <summary>Determines whether a number is odd.</summary>
        /// <param name="n">The number to check whether it's odd or not.</param>
        public static bool IsOdd(short n) => (n & 1) == 1;
        /// <summary>Determines whether a number is odd.</summary>
        /// <param name="n">The number to check whether it's odd or not.</param>
        public static bool IsOdd(int n) => (n & 1) == 1;
        /// <summary>Determines whether a number is odd.</summary>
        /// <param name="n">The number to check whether it's odd or not.</param>
        public static bool IsOdd(long n) => (n & 1) == 1;
        /// <summary>Determines whether a number is odd.</summary>
        /// <param name="n">The number to check whether it's odd or not.</param>
        public static bool IsOdd(sbyte n) => (n & 1) == 1;
        /// <summary>Determines whether a number is odd.</summary>
        /// <param name="n">The number to check whether it's odd or not.</param>
        public static bool IsOdd(ushort n) => (n & 1) == 1;
        /// <summary>Determines whether a number is odd.</summary>
        /// <param name="n">The number to check whether it's odd or not.</param>
        public static bool IsOdd(uint n) => (n & 1) == 1;
        /// <summary>Determines whether a number is odd.</summary>
        /// <param name="n">The number to check whether it's odd or not.</param>
        public static bool IsOdd(ulong n) => (n & 1) == 1;
        #endregion
    }
}