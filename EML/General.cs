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
        /// <summary>The constant π with 39-digit precision. This precision is enough for precise calculations in an atomic scale.</summary>
        public const decimal Pi = 3.141592653589793238462643383279502884197m;
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
        /// <summary>Returns the inverted value of a <seealso cref="byte"/>.</summary>
        /// <param name="d">The <seealso cref="byte"/> whose inverted value to return.</param>
        public static byte Invert(byte d) => (byte)(1 / d);
        /// <summary>Returns the inverted value of a <seealso cref="short"/>.</summary>
        /// <param name="d">The <seealso cref="short"/> whose inverted value to return.</param>
        public static short Invert(short d) => (short)(1 / d);
        /// <summary>Returns the inverted value of a <seealso cref="int"/>.</summary>
        /// <param name="d">The <seealso cref="int"/> whose inverted value to return.</param>
        public static int Invert(int d) => 1 / d;
        /// <summary>Returns the inverted value of a <seealso cref="long"/>.</summary>
        /// <param name="d">The <seealso cref="long"/> whose inverted value to return.</param>
        public static long Invert(long d) => 1 / d;
        /// <summary>Returns the inverted value of a <seealso cref="ushort"/>.</summary>
        /// <param name="d">The <seealso cref="ushort"/> whose inverted value to return.</param>
        public static ushort Invert(ushort d) => (ushort)(1 / d);
        /// <summary>Returns the inverted value of a <seealso cref="uint"/>.</summary>
        /// <param name="d">The <seealso cref="uint"/> whose inverted value to return.</param>
        public static uint Invert(uint d) => 1 / d;
        /// <summary>Returns the inverted value of a <seealso cref="ulong"/>.</summary>
        /// <param name="d">The <seealso cref="ulong"/> whose inverted value to return.</param>
        public static ulong Invert(ulong d) => 1 / d;
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
        #region Power
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static decimal Power(byte b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    decimal result = 1;
                    for (int i = 1; i <= absolutePower; i++)
                        result *= b;
                    return power > 0 ? result : Invert(result);
                }
                else return 1;
            }
            else
            {
                if (power != 0) return 0;
                else throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static decimal Power(short b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    decimal result = 1;
                    for (int i = 1; i <= absolutePower; i++)
                        result *= b;
                    return power > 0 ? result : Invert(result);
                }
                else return 1;
            }
            else
            {
                if (power != 0) return 0;
                else throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static decimal Power(int b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    decimal result = 1;
                    for (int i = 1; i <= absolutePower; i++)
                        result *= b;
                    return power > 0 ? result : Invert(result);
                }
                else return 1;
            }
            else
            {
                if (power != 0) return 0;
                else throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static decimal Power(long b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    decimal result = 1;
                    for (int i = 1; i <= absolutePower; i++)
                        result *= b;
                    return power > 0 ? result : Invert(result);
                }
                else return 1;
            }
            else
            {
                if (power != 0) return 0;
                else throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static decimal Power(sbyte b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    decimal result = 1;
                    for (int i = 1; i <= absolutePower; i++)
                        result *= b;
                    return power > 0 ? result : Invert(result);
                }
                else return 1;
            }
            else
            {
                if (power != 0) return 0;
                else throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static decimal Power(ushort b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    decimal result = 1;
                    for (int i = 1; i <= absolutePower; i++)
                        result *= b;
                    return power > 0 ? result : Invert(result);
                }
                else return 1;
            }
            else
            {
                if (power != 0) return 0;
                else throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static decimal Power(uint b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    decimal result = 1;
                    for (int i = 1; i <= absolutePower; i++)
                        result *= b;
                    return power > 0 ? result : Invert(result);
                }
                else return 1;
            }
            else
            {
                if (power != 0) return 0;
                else throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static decimal Power(ulong b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    decimal result = 1;
                    for (int i = 1; i <= absolutePower; i++)
                        result *= b;
                    return power > 0 ? result : Invert(result);
                }
                else return 1;
            }
            else
            {
                if (power != 0) return 0;
                else throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static decimal Power(float b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    decimal result = 1;
                    for (int i = 1; i <= absolutePower; i++)
                        result *= (decimal)b;
                    return power > 0 ? result : Invert(result);
                }
                else return 1;
            }
            else
            {
                if (power != 0) return 0;
                else throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static decimal Power(double b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    decimal result = 1;
                    for (int i = 1; i <= absolutePower; i++)
                        result *= (decimal)b;
                    return power > 0 ? result : Invert(result);
                }
                else return 1;
            }
            else
            {
                if (power != 0) return 0;
                else throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        /// <summary>Returns the power of a number.</summary>
        /// <param name="b">The base number to get the power of.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static decimal Power(decimal b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    decimal result = 1;
                    for (int i = 1; i <= absolutePower; i++)
                        result *= b;
                    return power > 0 ? result : Invert(result);
                }
                else return 1;
            }
            else
            {
                if (power != 0) return 0;
                else throw new ElevateZeroToThePowerOfZeroException();
            }
        }
        #endregion
        #region Factorial
        /// <summary>Returns the factorial of a number.</summary>
        /// <param name="b">The base number to get the factorial of.</param>
        public static decimal Factorial(byte b)
        {
            if (b == 0) return 1;
            else // Always positive; byte ranges from 0 to 255
            {
                decimal result = 1;
                for (byte i = 2; i <= b; i++)
                    result *= i;
                return result;
            }
        }
        /// <summary>Returns the factorial of a number.</summary>
        /// <param name="b">The base number to get the factorial of.</param>
        public static decimal Factorial(short b)
        {
            if (b == 0) return 1;
            else if (b > 0)
            {
                decimal result = 1;
                for (short i = 2; i <= b; i++)
                    result *= i;
                return result;
            }
            else throw new NegativeNumberFactorialException();
        }
        /// <summary>Returns the factorial of a number.</summary>
        /// <param name="b">The base number to get the factorial of.</param>
        public static decimal Factorial(int b)
        {
            if (b == 0) return 1;
            else if (b > 0)
            {
                decimal result = 1;
                for (int i = 2; i <= b; i++)
                    result *= i;
                return result;
            }
            else throw new NegativeNumberFactorialException();
        }
        /// <summary>Returns the factorial of a number.</summary>
        /// <param name="b">The base number to get the factorial of.</param>
        public static decimal Factorial(long b)
        {
            if (b == 0) return 1;
            else if (b > 0)
            {
                decimal result = 1;
                for (long i = 2; i <= b; i++)
                    result *= i;
                return result;
            }
            else throw new NegativeNumberFactorialException();
        }
        /// <summary>Returns the factorial of a number.</summary>
        /// <param name="b">The base number to get the factorial of.</param>
        public static decimal Factorial(sbyte b)
        {
            if (b == 0) return 1;
            else if (b > 0)
            {
                decimal result = 1;
                for (sbyte i = 2; i <= b; i++)
                    result *= i;
                return result;
            }
            else throw new NegativeNumberFactorialException();
        }
        /// <summary>Returns the factorial of a number.</summary>
        /// <param name="b">The base number to get the factorial of.</param>
        public static decimal Factorial(ushort b)
        {
            if (b == 0) return 1;
            else // Unsigned, always positive
            {
                decimal result = 1;
                for (ushort i = 2; i <= b; i++)
                    result *= i;
                return result;
            }
        }
        /// <summary>Returns the factorial of a number.</summary>
        /// <param name="b">The base number to get the factorial of.</param>
        public static decimal Factorial(uint b)
        {
            if (b == 0) return 1;
            else // Unsigned, always positive
            {
                decimal result = 1;
                for (uint i = 2; i <= b; i++)
                    result *= i;
                return result;
            }
        }
        /// <summary>Returns the factorial of a number.</summary>
        /// <param name="b">The base number to get the factorial of.</param>
        public static decimal Factorial(ulong b)
        {
            if (b == 0) return 1;
            else // Unsigned, always positive
            {
                decimal result = 1;
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
        public static decimal Factorization(byte start, byte end)
        {
            if (start < end)
            {
                decimal result = 1;
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
        public static decimal Factorization(short start, short end)
        {
            if (start < end)
            {
                if (start >= 0 && end >= 0)
                {
                    decimal result = 1;
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
        public static decimal Factorization(int start, int end)
        {
            if (start < end)
            {
                if (start >= 0 && end >= 0)
                {
                    decimal result = 1;
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
        public static decimal Factorization(long start, long end)
        {
            if (start < end)
            {
                if (start >= 0 && end >= 0)
                {
                    decimal result = 1;
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
        public static decimal Factorization(sbyte start, sbyte end)
        {
            if (start < end)
            {
                if (start >= 0 && end >= 0)
                {
                    decimal result = 1;
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
        public static decimal Factorization(ushort start, ushort end)
        {
            if (start < end)
            {
                decimal result = 1;
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
        public static decimal Factorization(uint start, uint end)
        {
            if (start < end)
            {
                decimal result = 1;
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
        public static decimal Factorization(ulong start, ulong end)
        {
            if (start < end)
            {
                decimal result = 1;
                for (ulong i = start; i <= end; i++)
                    result *= i;
                return result;
            }
            else if (start == end) return 1;
            else throw new InvalidFactorizationVariableOrderException();
        }
        #endregion
    }
}