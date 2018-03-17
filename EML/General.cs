﻿using System;
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
        public static double Power(byte b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    double result = 1;
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
        public static double Power(short b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    double result = 1;
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
        public static double Power(int b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    double result = 1;
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
        public static double Power(long b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    double result = 1;
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
        public static double Power(sbyte b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    double result = 1;
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
        public static double Power(ushort b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    double result = 1;
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
        public static double Power(uint b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    double result = 1;
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
        public static double Power(ulong b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    double result = 1;
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
        public static double Power(float b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    double result = 1;
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
        public static double Power(double b, int power)
        {
            if (b != 0)
            {
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    double result = 1;
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
        public static double Power(decimal b, int power)
        {
            if (b != 0)
            {
                double a = (double)b;
                if (power != 0)
                {
                    int absolutePower = AbsoluteValue(power);
                    double result = 1;
                    for (int i = 1; i <= absolutePower; i++)
                        result *= a;
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
            else if (rootClass % 2 == 0 && negative) throw new Exception(); // EvenClassRootOfNegativeNumberException
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
            else if (rootClass % 2 == 0 && negative) throw new Exception(); // EvenClassRootOfNegativeNumberException
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
            else if (rootClass % 2 == 0 && negative) throw new Exception(); // EvenClassRootOfNegativeNumberException
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
            else if (rootClass % 2 == 0 && negative) throw new Exception(); // EvenClassRootOfNegativeNumberException
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
    }
}