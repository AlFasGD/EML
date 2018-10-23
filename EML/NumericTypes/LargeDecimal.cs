using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.Tools;
using EML.Tools.Enumerations;
using EML.Exceptions;
using EML.Extensions;
using EML.Extensions.FloatingPointHelpers;

namespace EML.NumericTypes
{
    /// <summary>Represents an arbitrarily large decimal number.</summary>
    public struct LargeDecimal
    {
        // TODO: Implement properties from LargeInteger regarding signs and directions.
        /// <summary>The <seealso cref="byte"/> list representing the digits on the left side of the number from the decimal point (the integral part).</summary>
        public LongList<byte> LeftBytes { get; set; }
        /// <summary>The <seealso cref="byte"/> list representing the digits on the right side of the number from the decimal point (the decimal part).</summary>
        public LongList<byte> RightBytes { get; set; }
        /// <summary>The <seealso cref="Tools.Enumerations.Sign"/> of the <seealso cref="LargeDecimal"/>.</summary>
        public Sign Sign { get; set; }
        /// <summary>The sign of the <seealso cref="LargeDecimal"/> as a <seealso cref="bool"/>. If the sign is positive, this value is <see langword="true"/>, otherwise <see langword="false"/>.</summary>
        public bool BoolSign
        {
            get => Sign == Sign.Positive;
            set => Sign = value ? Sign.Positive : Sign.Negative;
        }
        /// <summary>The length of the left part of the instance of <seealso cref="LargeDecimal"/>.</summary>
        public long LeftLength => LeftBytes.Count;
        /// <summary>The length of the right part of the instance of <seealso cref="LargeDecimal"/>.</summary>
        public long RightLength => RightBytes.Count;
        /// <summary>The period part of the instance of <seealso cref="LargeDecimal"/>. It represents the length of the period.</summary>
        public long PeriodLength { get; private set; }

        #region Constants
        /// <summary>The constant π with a 100-digit precision.</summary>
        public static readonly LargeDecimal Pi  = new LargeDecimal("3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679");
        /// <summary>The constant π with a 250-digit precision. Especially made with lots of love and care for the grecophiles.</summary>
        public static readonly LargeDecimal π   = new LargeDecimal("3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679821480865132823066470938446095505822317253594081284811174502841027019385211055596446229489549303819644288109756659334461284756482337867831652712019091");
        /// <summary>The constant e with a 100-digit precision.</summary>
        public static readonly LargeDecimal e   = new LargeDecimal("2.7182818284590452353602874713526624977572470936999595749669676277240766303535475945713821785251664274");
        /// <summary>The constant φ with a 100-digit precision.</summary>
        public static readonly LargeDecimal Phi = new LargeDecimal("1.6180339887498948482045868343656381177203091798057628621354486227052604628189024497072072041893911374");
        #endregion
        #region Constructors
        /// <summary>Creates a new instance of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="b">The <seealso cref="byte"/> value to create the <seealso cref="LargeDecimal"/> from.</param>
        /// <param name="removeUnnecessaryBytes">Determines whether the unnecessary bytes should be removed during the initialization of the <seealso cref="LargeDecimal"/> or not.</param>
        public LargeDecimal(byte b, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>(b);
            RightBytes = new LongList<byte>();
            Sign = Sign.Positive;
            PeriodLength = 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="s">The <seealso cref="short"/> value to create the <seealso cref="LargeDecimal"/> from.</param>
        /// <param name="removeUnnecessaryBytes">Determines whether the unnecessary bytes should be removed during the initialization of the <seealso cref="LargeDecimal"/> or not.</param>
        public LargeDecimal(short s, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>(BitConverter.GetBytes(General.AbsoluteValue(s)));
            RightBytes = new LongList<byte>();
            Sign = s >= 0 ? Sign.Positive : Sign.Negative;
            PeriodLength = 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="i">The <seealso cref="int"/> value to create the <seealso cref="LargeDecimal"/> from.</param>
        /// <param name="removeUnnecessaryBytes">Determines whether the unnecessary bytes should be removed during the initialization of the <seealso cref="LargeDecimal"/> or not.</param>
        public LargeDecimal(int i, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>(BitConverter.GetBytes(General.AbsoluteValue(i)));
            RightBytes = new LongList<byte>();
            Sign = i >= 0 ? Sign.Positive : Sign.Negative;
            PeriodLength = 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="l">The <seealso cref="long"/> value to create the <seealso cref="LargeDecimal"/> from.</param>
        /// <param name="removeUnnecessaryBytes">Determines whether the unnecessary bytes should be removed during the initialization of the <seealso cref="LargeDecimal"/> or not.</param>
        public LargeDecimal(long l, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>(BitConverter.GetBytes(General.AbsoluteValue(l)));
            RightBytes = new LongList<byte>();
            Sign = l >= 0 ? Sign.Positive : Sign.Negative;
            PeriodLength = 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="b">The <seealso cref="sbyte"/> value to create the <seealso cref="LargeDecimal"/> from.</param>
        /// <param name="removeUnnecessaryBytes">Determines whether the unnecessary bytes should be removed during the initialization of the <seealso cref="LargeDecimal"/> or not.</param>
        public LargeDecimal(sbyte b, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>((byte)General.AbsoluteValue(b));
            RightBytes = new LongList<byte>();
            Sign = b >= 0 ? Sign.Positive : Sign.Negative;
            PeriodLength = 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="s">The <seealso cref="ushort"/> value to create the <seealso cref="LargeDecimal"/> from.</param>
        /// <param name="removeUnnecessaryBytes">Determines whether the unnecessary bytes should be removed during the initialization of the <seealso cref="LargeDecimal"/> or not.</param>
        public LargeDecimal(ushort s, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>(BitConverter.GetBytes(s));
            RightBytes = new LongList<byte>();
            Sign = Sign.Positive;
            PeriodLength = 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="i">The <seealso cref="uint"/> value to create the <seealso cref="LargeDecimal"/> from.</param>
        /// <param name="removeUnnecessaryBytes">Determines whether the unnecessary bytes should be removed during the initialization of the <seealso cref="LargeDecimal"/> or not.</param>
        public LargeDecimal(uint i, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>(BitConverter.GetBytes(i));
            RightBytes = new LongList<byte>();
            Sign = Sign.Positive;
            PeriodLength = 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="l">The <seealso cref="ulong"/> value to create the <seealso cref="LargeDecimal"/> from.</param>
        /// <param name="removeUnnecessaryBytes">Determines whether the unnecessary bytes should be removed during the initialization of the <seealso cref="LargeDecimal"/> or not.</param>
        public LargeDecimal(ulong l, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>(BitConverter.GetBytes(l));
            RightBytes = new LongList<byte>();
            Sign = Sign.Positive;
            PeriodLength = 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="f">The <seealso cref="float"/> value to create the <seealso cref="LargeDecimal"/> from.</param>
        /// <param name="removeUnnecessaryBytes">Determines whether the unnecessary bytes should be removed during the initialization of the <seealso cref="LargeDecimal"/> or not.</param>
        public LargeDecimal(float f, bool removeUnnecessaryBytes = true)
        {
            FloatAnalyzer a = new FloatAnalyzer(f);
            LeftBytes = new LongList<byte>(General.Max(a.Exponent / 8, 0) + 1);
            RightBytes = new LongList<byte>(General.Max((FloatAnalyzer.MantissaBits - a.Exponent) / 8, 0) + 1);
            for (int i = -1; i < FloatAnalyzer.MantissaBits;)
            {
                int currentExponent = a.Exponent - i + 1;
                int r = 8 - currentExponent % 8;
                byte value = i > -1 ? (byte)((a.Mantissa << i) >> (32 - r)) : (byte)1;
                if (currentExponent >= 0)
                    LeftBytes[currentExponent / 8] |= value;
                else
                    RightBytes[-currentExponent / 8] |= value;
            }
            Sign = a.Sign ? Sign.Positive : Sign.Negative;
            PeriodLength = 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="d">The <seealso cref="double"/> value to create the <seealso cref="LargeDecimal"/> from.</param>
        /// <param name="removeUnnecessaryBytes">Determines whether the unnecessary bytes should be removed during the initialization of the <seealso cref="LargeDecimal"/> or not.</param>
        public LargeDecimal(double d, bool removeUnnecessaryBytes = true)
        {
            DoubleAnalyzer a = new DoubleAnalyzer(d);
            LeftBytes = new LongList<byte>(General.Max(a.Exponent / 8, 0) + 1);
            RightBytes = new LongList<byte>(General.Max((DoubleAnalyzer.MantissaBits - a.Exponent) / 8, 0) + 1);
            for (int i = -1; i < DoubleAnalyzer.MantissaBits;)
            {
                int currentExponent = a.Exponent - i + 1;
                int r = 8 - currentExponent % 8;
                byte value = i > -1 ? (byte)((a.Mantissa << i) >> (64 - r)) : (byte)1;
                if (currentExponent >= 0)
                    LeftBytes[currentExponent / 8] |= value;
                else
                    RightBytes[-currentExponent / 8] |= value;
            }
            Sign = a.Sign ? Sign.Positive : Sign.Negative;
            PeriodLength = 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="d">The <seealso cref="decimal"/> value to create the <seealso cref="LargeDecimal"/> from.</param>
        /// <param name="removeUnnecessaryBytes">Determines whether the unnecessary bytes should be removed during the initialization of the <seealso cref="LargeDecimal"/> or not.</param>
        public LargeDecimal(decimal d, bool removeUnnecessaryBytes = true)
        {
            LargeDecimal a = Parse(d.ToString());
            LeftBytes = a.LeftBytes;
            RightBytes = a.RightBytes;
            Sign = a.Sign;
            PeriodLength = 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="l">The <seealso cref="LargeInteger"/> value to create the <seealso cref="LargeDecimal"/> from.</param>
        /// <param name="removeUnnecessaryBytes">Determines whether the unnecessary bytes should be removed during the initialization of the <seealso cref="LargeDecimal"/> or not.</param>
        public LargeDecimal(LargeInteger l, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = l.Bytes;
            RightBytes = new LongList<byte>();
            Sign = l.Sign;
            PeriodLength = 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="leftBytes">The array of <seealso cref="byte"/>s which will be used for the left part of the <seealso cref="LargeDecimal"/>.</param>
        /// <param name="rightBytes">The array of <seealso cref="byte"/>s which will be used for the right part of the <seealso cref="LargeDecimal"/>.</param>
        /// <param name="removeUnnecessaryBytes">Determines whether the unnecessary bytes should be removed during the initialization of the <seealso cref="LargeDecimal"/> or not.</param>
        public LargeDecimal(byte[] leftBytes, byte[] rightBytes, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>(leftBytes);
            RightBytes = new LongList<byte>(rightBytes);
            Sign = Sign.Positive;
            PeriodLength = 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="s">The <seealso cref="string"/> that will be parsed to create the <seealso cref="LargeDecimal"/> from.</param>
        /// <param name="removeUnnecessaryBytes">Determines whether the unnecessary bytes should be removed during the initialization of the <seealso cref="LargeDecimal"/> or not.</param>
        public LargeDecimal(string s, bool removeUnnecessaryBytes = true)
        {
            this = Parse(s);
        }
        #endregion
        #region Implicit Conversions
        public static implicit operator LargeDecimal(byte a) => new LargeDecimal(a);
        public static implicit operator LargeDecimal(short a) => new LargeDecimal(a);
        public static implicit operator LargeDecimal(int a) => new LargeDecimal(a);
        public static implicit operator LargeDecimal(long a) => new LargeDecimal(a);
        public static implicit operator LargeDecimal(sbyte a) => new LargeDecimal(a);
        public static implicit operator LargeDecimal(ushort a) => new LargeDecimal(a);
        public static implicit operator LargeDecimal(uint a) => new LargeDecimal(a);
        public static implicit operator LargeDecimal(ulong a) => new LargeDecimal(a);
        public static implicit operator LargeDecimal(float a) => new LargeDecimal(a);
        public static implicit operator LargeDecimal(double a) => new LargeDecimal(a);
        public static implicit operator LargeDecimal(decimal a) => new LargeDecimal(a);
        public static implicit operator LargeDecimal(LargeInteger a) => new LargeDecimal(a);
        #endregion
        #region Type Casts
        // TODO: Create a class containing a function that returns the size of the value in bits depending on the structure
        public static explicit operator byte(LargeDecimal a)
        {
            int size = sizeof(byte) * 8;
            if (!a.BoolSign)
                throw new InvalidOperationException("The LargeDecimal was negative, which value is unsupported by byte.");
            if (a.GetLeftBitCount() <= size)
                return a.LeftBytes[0];
            else
                throw new OverflowException("The LargeDecimal was too big.");
        }
        public static explicit operator short(LargeDecimal a)
        {
            int size = sizeof(short) * 8 - 1;
            if (a.GetLeftBitCount() <= size)
            {
                LongList<byte> bytes = a.LeftBytes;
                bytes.AddRange(new byte[2 - bytes.Count]);
                return ((BitConverter.ToInt16(bytes.ToArray(), 0) << 1) >> 1) | (!a.BoolSign ? 1 << size : 0);
            }
            else
                throw new OverflowException("The LargeDecimal was too big.");
        }
        public static explicit operator int(LargeDecimal a)
        {
            int size = sizeof(int) * 8 - 1;
            if (a.GetLeftBitCount() <= size)
            {
                LongList<byte> bytes = a.LeftBytes;
                bytes.AddRange(new byte[4 - bytes.Count]);
                return ((BitConverter.ToInt32(bytes.ToArray(), 0) << 1) >> 1) | (!a.BoolSign ? 1 << size : 0);
            }
            else
                throw new OverflowException("The LargeDecimal was too big.");
        }
        public static explicit operator long(LargeDecimal a)
        {
            int size = sizeof(long) * 8 - 1;
            if (a.GetLeftBitCount() <= size)
            {
                LongList<byte> bytes = a.LeftBytes;
                bytes.AddRange(new byte[8 - bytes.Count]);
                return ((BitConverter.ToInt64(bytes.ToArray(), 0) << 1) >> 1) | (!a.BoolSign ? 1 << size : 0);
            }
            else
                throw new OverflowException("The LargeDecimal was too big.");
        }
        public static explicit operator sbyte(LargeDecimal a)
        {
            int size = sizeof(sbyte) * 8 - 1;
            if (a.GetLeftBitCount() <= size)
                return (((sbyte)a.LeftBytes[0] << 1) >> 1) | (!a.BoolSign ? 1 << size : 0);
            else
                throw new OverflowException("The LargeDecimal was too big.");
        }
        public static explicit operator ushort(LargeDecimal a)
        {
            int size = sizeof(ushort) * 8;
            if (!a.BoolSign)
                throw new InvalidOperationException("The LargeDecimal was negative, which value is unsupported by ushort.");
            if (a.GetLeftBitCount() <= size)
            {
                LongList<byte> bytes = a.LeftBytes;
                bytes.AddRange(new byte[2 - bytes.Count]);
                return BitConverter.ToUInt16(bytes.ToArray(), 0);
            }
            else
                throw new OverflowException("The LargeDecimal was too big.");
        }
        public static explicit operator uint(LargeDecimal a)
        {
            int size = sizeof(uint) * 8;
            if (!a.BoolSign)
                throw new InvalidOperationException("The LargeDecimal was negative, which value is unsupported by uint.");
            if (a.GetLeftBitCount() <= size)
            {
                LongList<byte> bytes = a.LeftBytes;
                bytes.AddRange(new byte[4 - bytes.Count]);
                return BitConverter.ToUInt32(bytes.ToArray(), 0);
            }
            else
                throw new OverflowException("The LargeDecimal was too big.");
        }
        public static explicit operator ulong(LargeDecimal a)
        {
            int size = sizeof(ulong) * 8;
            if (!a.BoolSign)
                throw new InvalidOperationException("The LargeDecimal was negative, which value is unsupported by ulong.");
            if (a.GetLeftBitCount() <= size)
            {
                LongList<byte> bytes = a.LeftBytes;
                bytes.AddRange(new byte[8 - bytes.Count]);
                return BitConverter.ToUInt64(bytes.ToArray(), 0);
            }
            else
                throw new OverflowException("The LargeDecimal was too big.");
        }
        public static explicit operator float(LargeDecimal a)
        {
            try
            {
                float result = 0;
                for (long i = a.LeftLength - 1; i >= General.Max(a.LeftLength - 4, -a.RightLength); i--)
                    result += (i < 0 ? a.RightBytes[-i - 1] : a.LeftBytes[i]) * (float)General.Power(2, i * 8);
                return result * (int)a.Sign;
            }
            catch
            {
                throw new OverflowException("The LargeDecimal was too big.");
            }
        }
        public static explicit operator double(LargeDecimal a)
        {
            try
            {
                double result = 0;
                for (long i = a.LeftLength - 1; i >= General.Max(a.LeftLength - 8, -a.RightLength); i--)
                    result += (i < 0 ? a.RightBytes[-i - 1] : a.LeftBytes[i]) * General.Power(2, i * 8);
                return result * (int)a.Sign;
            }
            catch
            {
                throw new OverflowException("The LargeDecimal was too big.");
            }
        }
        public static explicit operator decimal(LargeDecimal a)
        {
            try
            {
                decimal result = 0;
                for (long i = a.LeftLength - 1; i >= General.Max(a.LeftLength - 12, -a.RightLength); i--)
                    result += (i < 0 ? a.RightBytes[-i - 1] : a.LeftBytes[i]) * (decimal)General.Power(2, i * 8);
                return result * (int)a.Sign;
            }
            catch
            {
                throw new OverflowException("The LargeDecimal was too big.");
            }
        }
        public static explicit operator LargeInteger(LargeDecimal a) 
        {
            LargeInteger result = new LargeInteger(a.LeftBytes);
            result.Sign = a.Sign;
            // Uncomment once feature is implemented
            //result.SignDirection = a.SignDirection
            return result;
        }
        #endregion
        #region Operators
        public static LargeDecimal operator +(LargeDecimal left, LargeDecimal right)
        {
            // Avoid unnecessary operations early
            if (left == Zero)
                return right;
            if (right == Zero)
                return left;

            // Add the maximum number of bytes between the two integers and another one to avoid overflows
            LargeDecimal result = new LargeDecimal(new byte[General.Max(left.LeftLength, right.LeftLength) + 1], new byte[General.Max(left.RightLength, right.RightLength) + 1], false);

            // Determine the sign of the result
            if (left.BoolSign == right.BoolSign)
                result.BoolSign = left.BoolSign;
            else
            {
                if (left.LeftLength == right.LeftLength)
                {
                    bool done = false;
                    if (left.LeftLength == 1 && left.LeftBytes[0] == 0 && right.LeftBytes[0] == 0) // Expensive check for whether both numbers are within (-1, 1)
                    {
                        for (long i = 0; i < left.RightLength && !done; i++)
                            if (done = left.RightBytes[i] != right.RightBytes[i])
                                result.BoolSign = (left.RightBytes[i] > right.RightBytes[i]) && left.BoolSign;
                        if (!done)
                        {
                            // Optimized for taking care of potentially identical period parts
                            // May need to prioritize more general functionality and let really similar periods take little more time to process
                            var leftPeriod = left.GetPeriod();
                            var rightPeriod = right.GetPeriod();
                            if (leftPeriod == rightPeriod)
                                return Zero;
                            for (long i = 0; !done; i++)
                            {
                                long l = i % left.PeriodLength;
                                long r = i % right.PeriodLength;
                                if (done = leftPeriod.GetBitAt(l) != rightPeriod.GetBitAt(r)) // Won't cause infinite loops
                                    result.BoolSign = (leftPeriod.GetBitAt(l) > rightPeriod.GetBitAt(r)) && left.BoolSign;
                            }
                        }
                    }
                    else
                        for (long i = left.LeftLength - 1; i >= 0 && !done; i--)
                            if (done = left.LeftBytes[i] != right.LeftBytes[i])
                                result.BoolSign = (left.LeftBytes[i] > right.LeftBytes[i]) && left.BoolSign;
                }
                else
                    result.BoolSign = (left.LeftLength > right.LeftLength) && left.BoolSign;
                // Avoid directly calculating negative sums, simply negate the sum of both numbers whose sum is a positive one
                if (!result.BoolSign)
                {
                    Sign r = result.Sign;
                    result = -right - left;
                    result.Sign = r;
                    return result;
                }
            }

            ExtendPeriodToMatchDigitCounts(ref left, ref right, out result.PeriodLength);
            
            // Perform the calculation
            for (long i = -result.RightLength; i < result.LeftLength; i++) // Insert the result per bytes
            {
                int sum = 0;

                if (i >= 0)
                {
                    if (i < left.LeftLength && i < right.LeftLength)
                        sum = left.LeftBytes[i] * (int)left.Sign + right.LeftBytes[i] * (int)right.Sign;
                    else if (i < left.LeftLength && i >= right.LeftLength)
                        sum = left.LeftBytes[i] * (int)left.Sign;
                    else if (i >= left.LeftLength && i < right.LeftLength)
                        sum = right.LeftBytes[i] * (int)right.Sign;
                }
                else
                {
                    long index = -i - 1;

                    if (index < left.RightLength && index < right.RightLength)
                        sum = left.RightBytes[index] * (int)left.Sign + right.RightBytes[index] * (int)right.Sign;
                    else if (index < left.RightLength && index >= right.RightLength)
                        sum = left.RightBytes[index] * (int)left.Sign;
                    else if (index >= left.RightLength && index < right.RightLength)
                        sum = right.RightBytes[index] * (int)right.Sign;
                }

                if (sum == 0) // Ignore the sum if it's 0
                    continue;

                if (i >= 0)
                {
                    if (sum >= 256 - result.LeftBytes[i]) // If the sum is positive and adding that to the current byte will cause an overflow
                    {
                        result.LeftBytes[i] = (byte)((sum + result.LeftBytes[i]) % 256);
                        int t;
                        long j = i + 1;
                        do
                        {
                            t = result.LeftBytes[j] + 1;
                            result.LeftBytes[j] = (byte)(t % 256);
                            j++;
                        }
                        while (j < result.LeftLength && t / 256 != 0);
                    }
                    else if (sum <= -result.LeftBytes[i]) // If the sum is negative and adding its absolute value to the current byte will cause an overflow
                    {
                        result.LeftBytes[i] = (byte)(256 + sum - result.LeftBytes[i]);
                        int t;
                        long j = i + 1;
                        do
                        {
                            t = result.LeftBytes[j] - 1;
                            result.LeftBytes[j]--;
                            j++;
                        }
                        while (j < result.LeftLength && t < 0);
                    }
                    else // The sum can be normally added
                        result.LeftBytes[i] += (byte)sum;
                }
                else // Re-evaluate
                {
                    long index = -i - 1;

                    if (sum >= 256 - result.RightBytes[index]) // If the sum is positive and adding that to the current byte will cause an overflow
                    {
                        result.RightBytes[index] = (byte)((sum + result.RightBytes[index]) % 256);
                        int t;
                        long j = index + 1;
                        do
                        {
                            t = result.RightBytes[j] + 1;
                            result.RightBytes[j] = (byte)(t % 256);
                            j++;
                        }
                        while (j < result.RightLength && t / 256 != 0);
                    }
                    else if (sum <= -result.RightBytes[index]) // If the sum is negative and adding its absolute value to the current byte will cause an overflow
                    {
                        result.RightBytes[index] = (byte)(256 + sum - result.RightBytes[index]);
                        int t;
                        long j = index + 1;
                        do
                        {
                            t = result.RightBytes[j] - 1;
                            result.RightBytes[j]--;
                            j++;
                        }
                        while (j < result.RightLength && t < 0);
                    }
                    else // The sum can be normally added
                        result.RightBytes[index] += (byte)sum;
                }
            }

            result.RemoveUnnecessaryBytes();
            return result;
        }
        public static LargeDecimal operator -(LargeDecimal left, LargeDecimal right) => left + (-right);
        public static LargeDecimal operator *(LargeDecimal left, LargeDecimal right)
        {
            if (left == 0 || right == 0)
                return 0;
            
            LargeDecimal result = 0;
            result.BoolSign = left.Sign == right.Sign;
            left.BoolSign = right.BoolSign = true;
            ExtendPeriodToMatchDigitCounts(ref left, ref right, out result.PeriodLength);
            
            long shifts = (right.LeftLength - 1) * 8 + right.GetLastLeftBitIndex() - result.PeriodLength;
            LargeInteger l = new LargeInteger(ShiftLeft(left, shifts));
            LargeInteger r = new LargeInteger(ShiftLeft(right, shifts));
            result |= ShiftRight(new LargeDecimal(l * r), shifts * 2);
            
            var leftPeriod = left.GetPeriod();
            var rightPeriod = right.GetPeriod();
            
            // TODO: Validate for non-periodical instances of numbers
            var leftPeriodFraction = new Fraction(LargeInteger.Max(1, leftPeriod), ShiftLeft(1, LargeInteger.Max(1, left.PeriodLength)) - 1);
            var rightPeriodFraction = new Fraction(LargeInteger.Max(1, rightPeriod), ShiftLeft(1, LargeInteger.Max(1, right.PeriodLength)) - 1);
            var resultPeriodFraction = leftPeriodFraction * rightPeriodFraction;
            resultPeriodFraction.Simplify();
            
            for (LargeInteger i = 1; i % resultPeriodFraction.Denominator != 0; (i <<= 1).Bytes[0] |= 1);
            
            LargeInteger p = resultPeriodFraction.Nominator * (i / resultPeriodFraction.Denominator);
            result |= ShiftRight(new LargeDecimal(p), shifts * 2 + result.PeriodLength);
            
            return result;
        }
        /*
           Copyright stuff

           Use of this program, for any purpose, is granted the author,
           Ian Kaplan, as long as this copyright notice is included in
           the source code or any source code derived from this program.
           The user assumes all responsibility for using this code.

           Ian Kaplan, October 1996
        */
        // The division and modulus operations are using copyrighted code form the owner as stated in the previously pasted claim by Ian Kaplan
        // This is a transcription in C# from the source as written in C++, however copyright applies for the algorithm expressed as code
        public static LargeDecimal operator /(LargeDecimal left, LargeDecimal right)
        {
            if (right != 0)
            {
                LargeInteger leftInt = LargeInteger.AbsoluteValue(new LargeInteger(ShiftLeft(left, left.RightLength * 8 - 7 + left.GetLastRightBitIndex())));
                LargeInteger rightInt = LargeInteger.AbsoluteValue(new LargeInteger(ShiftLeft(right, right.RightLength * 8 - 7 + right.GetLastRightBitIndex())));
                if (leftInt == rightInt)
                    return (int)SignFunctions.Multiply(left.Sign, right.Sign);
                else if (rightInt == 1)
                    return left * (int)SignFunctions.Multiply(left.Sign, right.Sign);
                else
                {
                    LargeDecimal result = 0;
                    result.Sign = SignFunctions.Multiply(left.Sign, right.Sign);
                    long numBits = leftInt.Length * 8;
                    long decBits = 0;
                    LargeInteger t, q, remainder = 0;
                    while (remainder < rightInt)
                        remainder = (remainder << 1) | leftInt.GetBitAt(--numBits);

                    /* The loop, above, always goes one iteration too far.
                       To avoid inserting an "if" statement inside the loop
                       the last iteration is simply reversed. */
                    
                    remainder >>= 1;
                    numBits++;

                    for (long i = 1; i <= numBits; i++)
                    {
                        remainder = (remainder << 1) | leftInt.GetBitAt(numBits - i);
                        t = remainder - rightInt;
                        result <<= 1;
                        if (!t.BoolSign)
                        {
                            result.LeftBytes[0] |= (byte)1;
                            remainder = LargeInteger.AbsoluteValue(t);
                        }
                    }
                    LongList<LargeInteger> previousRemainders = new LongList<LargeInteger>(remainder);
                    long l = -1;
                    while (remainder > 0 && l == -1)
                    {
                        if (decBits % 8 == 0)
                            result.RightBytes.Add((byte)0);
                        remainder <<= 1;
                        t = remainder - rightInt;
                        if (!t.BoolSign)
                        {
                            result.RightBytes[decBits / 8] |= (byte)(1 << ((7 - decBits) % 8));
                            remainder = LargeInteger.AbsoluteValue(t);
                        }
                        l = previousRemainders.IndexOf(remainder);
                        result.PeriodLength = (previousRemainders.Count - l) % (previousRemainders.Count + 1);
                        decBits++;
                    }
                    return result;
                }
            }
            else throw new DivideByZeroException("Cannot divide by zero.");
        }
        public static LargeDecimal operator ++(LargeDecimal l) => l + 1;
        public static LargeDecimal operator --(LargeDecimal l) => l - 1;
        public static LargeDecimal operator >>(LargeDecimal left, int right) => ShiftRight(left, right);
        public static LargeDecimal operator <<(LargeDecimal left, int right) => ShiftLeft(left, right);
        public static LargeDecimal operator -(LargeDecimal l)
        {
            l.BoolSign = !l.BoolSign;
            return l;
        }
        public static LargeDecimal operator &(LargeDecimal left, LargeDecimal right)
        {
            long minLeftLength = General.Min(left.LeftLength, right.LeftLength);
            long minRightLength = General.Min(left.RightLength, right.RightLength);

            byte[] leftBytes = new byte[minLeftLength];
            byte[] rightBytes = new byte[minRightLength];

            for (long i = 0; i < minLeftLength; i++)
                leftBytes[i] = (byte)(left.LeftBytes[i] & right.LeftBytes[i]);
            for (long i = 0; i < minRightLength; i++)
                rightBytes[i] = (byte)(left.RightBytes[i] & right.RightBytes[i]);
            return new LargeDecimal(leftBytes, rightBytes);
        }
        public static LargeDecimal operator |(LargeDecimal left, LargeDecimal right)
        {
            long maxLeftLength = General.Max(left.LeftLength, right.LeftLength);
            long maxRightLength = General.Max(left.RightLength, right.RightLength);

            byte[] leftBytes = new byte[maxLeftLength];
            byte[] rightBytes = new byte[maxRightLength];

            for (long i = 0; i < maxLeftLength; i++)
            {
                int l = i < left.LeftLength ? left.LeftBytes[i] : 0;
                int r = i < right.LeftLength ? right.LeftBytes[i] : 0;
                leftBytes[i] = (byte)(l | r);
            }
            for (long i = 0; i < maxRightLength; i++)
            {
                int l = i < left.RightLength ? left.RightBytes[i] : 0;
                int r = i < right.RightLength ? right.RightBytes[i] : 0;
                rightBytes[i] = (byte)(l | r);
            }
            return new LargeDecimal(leftBytes, rightBytes);
        }
        public static LargeDecimal operator ^(LargeDecimal left, LargeDecimal right)
        {
            long maxLeftLength = General.Max(left.LeftLength, right.LeftLength);
            long maxRightLength = General.Max(left.RightLength, right.RightLength);

            byte[] leftBytes = new byte[maxLeftLength];
            byte[] rightBytes = new byte[maxRightLength];

            for (long i = 0; i < maxLeftLength; i++)
            {
                int l = i < left.LeftLength ? left.LeftBytes[i] : 0;
                int r = i < right.LeftLength ? right.LeftBytes[i] : 0;
                leftBytes[i] = (byte)(l ^ r);
            }
            for (long i = 0; i < maxRightLength; i++)
            {
                int l = i < left.RightLength ? left.RightBytes[i] : 0;
                int r = i < right.RightLength ? right.RightBytes[i] : 0;
                rightBytes[i] = (byte)(l ^ r);
            }
            return new LargeDecimal(leftBytes, rightBytes);
        }
        public static LargeDecimal operator ~(LargeDecimal l)
        {
            for (long i = 0; i < l.RightLength; i++)
                l.RightBytes[i] = (byte)~l.RightBytes[i];
            for (long i = 0; i < l.LeftLength; i++)
                l.LeftBytes[i] = (byte)~l.LeftBytes[i];
            return l;
        }
        public static bool operator >(LargeDecimal left, LargeDecimal right)
        {
            if (left.BoolSign == right.BoolSign)
            {
                if (left.LeftLength != right.LeftLength)
                    return left.BoolSign && left.LeftLength > right.LeftLength;
                else
                {
                    for (long i = left.LeftLength - 1; i >= 0; i--)
                        if (left.LeftBytes[i] > right.LeftBytes[i])
                            return left.BoolSign;

                    long currentBitIndex = 0;

                    long leftPeriodStart = left.RightLength * 8 - left.PeriodLength;
                    long rightPeriodStart = right.RightLength * 8 - right.PeriodLength;

                    long leftPeriodBitIndex = -1;
                    long rightPeriodBitIndex = -1;

                    long greaterPeriodBitIndex = General.Max(leftPeriodStart, rightPeriodStart);

                    long leftPeriodStartBitIndex = (greaterPeriodBitIndex - leftPeriodStart) % left.PeriodLength;
                    long rightPeriodStartBitIndex = (greaterPeriodBitIndex - rightPeriodStart) % right.PeriodLength;

                    while (leftPeriodBitIndex != leftPeriodStartBitIndex || rightPeriodBitIndex != rightPeriodStartBitIndex)
                    {
                        if (currentBitIndex < leftPeriodStart && currentBitIndex < rightPeriodStart)
                        {
                            byte s = (byte)(8 - General.Min(leftPeriodStart - currentBitIndex, 8));
                            byte leftByte = (byte)((left.RightBytes[currentBitIndex / 8] >> s) << s);
                            byte rightByte = (byte)((right.RightBytes[currentBitIndex / 8] >> s) << s);

                            if (leftByte > rightByte)
                                return left.BoolSign;

                            currentBitIndex += 8 - s;
                        }
                        else
                        {
                            if (leftPeriodBitIndex == -1)
                                leftPeriodBitIndex = currentBitIndex >= leftPeriodStart ? (currentBitIndex - leftPeriodStart) % left.PeriodLength : -1;
                            if (rightPeriodBitIndex == -1)
                                rightPeriodBitIndex = currentBitIndex >= rightPeriodStart ? (currentBitIndex - rightPeriodStart) % right.PeriodLength : -1;

                            byte leftByte = left.GetRightBitAt(leftPeriodBitIndex > -1 ? leftPeriodStart + leftPeriodBitIndex : currentBitIndex);
                            byte rightByte = right.GetRightBitAt(rightPeriodBitIndex > -1 ? rightPeriodStart + rightPeriodBitIndex : currentBitIndex);

                            if (leftByte > rightByte)
                                return left.BoolSign;

                            currentBitIndex++;
                            leftPeriodBitIndex = ++leftPeriodBitIndex % left.PeriodLength;
                            rightPeriodBitIndex = ++rightPeriodBitIndex % right.PeriodLength;
                        }
                    }
                }
                return !left.BoolSign;
            }
            else
                return left.BoolSign;
        }
        public static bool operator <(LargeDecimal left, LargeDecimal right) => right > left;
        public static bool operator >=(LargeDecimal left, LargeDecimal right) => left > right || left == right;
        public static bool operator <=(LargeDecimal left, LargeDecimal right) => right >= left;
        public static bool operator ==(LargeDecimal left, LargeDecimal right)
        {
            if (left.LeftLength != right.LeftLength || left.RightLength != right.RightLength)
                return false;
            
            for (long i = 0; i < left.LeftLength; i++)
                if (left.LeftBytes[i] != right.LeftBytes[i])
                    return false;
            for (long i = 0; i < left.RightLength; i++)
                if (left.RightBytes[i] != right.RightBytes[i])
                    return false;
            return left.PeriodLength == left.RightLength;
        }
        public static bool operator !=(LargeDecimal left, LargeDecimal right)
        {
            if (left.LeftLength != right.LeftLength || left.RightLength != right.RightLength)
                return true;
           
            for (long i = 0; i < left.LeftLength; i++)
                if (left.LeftBytes[i] != right.LeftBytes[i])
                    return true;
            for (long i = 0; i < left.RightLength; i++)
                if (left.RightBytes[i] != right.RightBytes[i])
                    return true;
            return left.PeriodLength != left.RightLength;
        }
        #endregion
        #region Constants
        // The constant values are converted to (s)bytes so as to minimize the cost of removing bytes
        /// <summary>Represents the number 0.</summary>
        public static readonly LargeDecimal Zero = new LargeDecimal((byte)0);
        /// <summary>Represents the number 1.</summary>
        public static readonly LargeDecimal One = new LargeDecimal((byte)1);
        /// <summary>Represents the number -1.</summary>
        public static readonly LargeDecimal NegativeOne = new LargeDecimal((sbyte)-1);
        #endregion
        #region Operations
        /// <summary>Returns the value enclosed between the minimum specified value and the maximum specified value.</summary>
        /// <param name="min">The minimum specified value.</param>
        /// <param name="max">The maximum specified value.</param>
        public LargeDecimal Clamp(LargeDecimal min, LargeDecimal max) => Clamp(min, this, max);
        /// <summary>Gets the period of this <seealso cref="LargeDecimal"/> and returns it as a <seealso cref="LargeInteger"/>.</summary>
        public LargeInteger GetPeriod()
        {
            if (PeriodLength == 0)
                return LargeInteger.Zero;
            LongList<byte> period = new LongList<byte>();
            int s = (int)(PeriodLength % 8);
            for (long i = PeriodLength; i > 0; i -= 8)
                period.Add((byte)((RightBytes[i] >> s) | (RightBytes[i + 1] << (8 - s))));
            return new LargeInteger(period);
        }
        /// <summary>Gets a part of the period of this <seealso cref="LargeDecimal"/> and returns it as a <seealso cref="LargeInteger"/>.</summary>
        /// <param name="range">The total number of bits in the period that will be returned.</param>
        public LargeInteger GetPeriod(long range)
        {
            if (range == 0)
                return LargeInteger.Zero;
            LongList<byte> period = new LongList<byte>();
            int s = (int)(range % 8);
            for (long i = range; i > 0; i -= 8)
                period.Add((byte)((RightBytes[i] >> s) | (RightBytes[i + 1] << (8 - s))));
            return new LargeInteger(period);
        }
        /// <summary>Gets the index of the last non-zero bit in the last byte of the left part of the <seealso cref="LargeDecimal"/>.</summary>
        internal byte GetLastLeftBitIndex()
        {
            byte result = 7;
            byte last = LeftBytes.Last();
            while ((last << result) >> 7 == 0)
                result--;
            return result;
        }
        /// <summary>Gets the index of the last non-zero bit in the last byte of the right part of the <seealso cref="LargeDecimal"/>.</summary>
        internal byte GetLastRightBitIndex()
        {
            byte result = 7;
            byte last = RightBytes.Last();
            while ((last << result) >> 7 == 0)
                result--;
            return result;
        }
        /// <summary>Gets the count of the used bits (excluding unnecessary zeroes) on the left part of the <seealso cref="LargeDecimal"/>.</summary>
        internal long GetLeftBitCount() => (LeftLength - 1) * 8 + GetLastLeftBitIndex() + 1;
        /// <summary>Gets the count of the used bits (excluding unnecessary zeroes) on the right part of the <seealso cref="LargeDecimal"/>.</summary>
        internal long GetRightBitCount() => (RightLength - 1) * 8 + GetLastRightBitIndex() + 1;
        /// <summary>Gets the selected bit at the specified index of the left bytes of this <seealso cref="LargeDecimal"/> as a <seealso cref="byte"/>.</summary>
        /// <param name="index">The index of the bit.</param>
        public byte GetLeftBitAt(long index) => (byte)((LeftBytes[index / 8] << (int)(8 - index % 8)) >> (int)(index % 8));
        /// <summary>Gets the selected bit at the specified index of the right bytes of this <seealso cref="LargeDecimal"/> as a <seealso cref="byte"/>.</summary>
        /// <param name="index">The index of the bit.</param>
        public byte GetRightBitAt(long index) => (byte)((RightBytes[index / 8] << (int)(8 - index % 8)) >> (int)(index % 8));
        /// <summary>Removes the useless null bytes in the <seealso cref="LargeDecimal"/>.</summary>
        private void RemoveUnnecessaryBytes()
        {
            long i = 0;
            while (i < LeftLength && LeftBytes[LeftLength - i - 1] == 0)
                i++;
            LeftBytes.RemoveLast(i);
            i = 0;
            while (i < RightLength && RightBytes[RightLength - i - 1] == 0)
                i++;
            RightBytes.RemoveLast(i);
        }
        #endregion
        #region Static Operations
        internal static void ExtendPeriodToMatchDigitCounts(ref LargeDecimal left, ref LargeDecimal right, out long targetPeriodLength)
        {
            // If both numbers are repeating, expand them accordingly to calculate the repeating part
            if ((left.PeriodLength | right.PeriodLength) > 0)
            {
                byte leftLast = left.GetLastRightBitIndex();
                byte rightLast = right.GetLastRightBitIndex();

                long leftCurrent = left.RightLength - 1;
                long rightCurrent = right.RightLength - 1;

                long leftCurrentBit = (left.RightLength - 1) * 8 + leftLast;
                long rightCurrentBit = (right.RightLength - 1) * 8 + rightLast;

                long leftNormalLastBit = leftCurrentBit - left.PeriodLength; // WARNING: Potential underflow when the period begins at the very start of the decimal part
                long rightNormalLastBit = rightCurrentBit - right.PeriodLength;
                long leftNormalLastIndex = leftNormalLastBit / 8;
                long rightNormalLastIndex = rightNormalLastBit / 8;

                // Ensure the normal part of both numbers is enough for the period parts to not interfere with the normal part
                if (left.PeriodLength > 0)
                    while (leftNormalLastBit < rightNormalLastBit)
                    {
                        byte s = (byte)(leftCurrentBit % 8);
                        left.RightBytes[leftCurrent] |= (byte)((left.RightBytes[leftNormalLastIndex] << s) >> s); // Re-evaluate this
                        leftNormalLastBit = leftCurrentBit += 8 - s;
                        leftCurrent++;
                        left.RightBytes.Add(0);
                    }

                if (right.PeriodLength > 0)
                    while (rightNormalLastBit < leftNormalLastBit)
                    {
                        byte s = (byte)(rightCurrentBit % 8);
                        right.RightBytes[rightCurrent] |= (byte)((right.RightBytes[rightNormalLastIndex] << s) >> s);
                        rightNormalLastBit = rightCurrentBit += 8 - s;
                        rightCurrent++;
                        right.RightBytes.Add(0);
                    }

                try
                {
                    targetPeriodLength = General.LeastCommonMultiple(left.PeriodLength, right.PeriodLength);
                }
                catch (DivideByZeroException) // In the case that one of the period lengths are 0, consider only using the one that's positive
                {
                    targetPeriodLength = General.Max(left.PeriodLength, right.PeriodLength);
                }

                long leftPeriodPart = left.PeriodLength;
                long rightPeriodPart = right.PeriodLength;

                // Ensure both periods are extended accordingly
                if (leftPeriodPart > 0)
                {
                    long remaining = targetPeriodLength - leftPeriodPart;
                    var p = left.GetPeriod(General.Min(remaining, left.PeriodLength));
                    while (leftPeriodPart < targetPeriodLength)
                    {
                        byte b = (byte)(leftCurrentBit % 8);
                        byte r = (byte)General.Min(8 - b, remaining);
                        left.RightBytes[leftCurrent] |= (byte)((p.Bytes[(leftPeriodPart % left.PeriodLength) / 8] >> (8 - r)) << (int)(leftCurrent * 8 - leftCurrentBit - r));
                        leftPeriodPart += r;
                        leftCurrentBit += r;
                        remaining -= r;
                        leftCurrent++;
                        left.RightBytes.Add(0);

                        if (leftPeriodPart >= targetPeriodLength) // Needed to avoid the case of reaching target before this part
                            break;

                        b = (byte)(leftPeriodPart % 8);
                        r = (byte)General.Min(8 - b, remaining);
                        byte a = (byte)((b + r) % 8);
                        left.RightBytes[leftCurrent] |= (byte)((p.Bytes[(leftPeriodPart % left.PeriodLength) / 8] >> a) << (int)(leftPeriodPart % 8 - a));
                        leftPeriodPart += r;
                        leftCurrentBit += r;
                        remaining -= r;
                        leftCurrent++;
                    }
                }

                if (rightPeriodPart > 0)
                {
                    long remaining = targetPeriodLength - rightPeriodPart;
                    var p = right.GetPeriod(General.Min(remaining, right.PeriodLength));
                    while (rightPeriodPart < targetPeriodLength)
                    {
                        byte b = (byte)(rightCurrentBit % 8);
                        byte r = (byte)General.Min(8 - b, remaining);
                        right.RightBytes[rightCurrent] |= (byte)((p.Bytes[(rightPeriodPart % right.PeriodLength) / 8] >> (8 - r)) << (int)(rightCurrent * 8 - rightCurrentBit - r));
                        rightPeriodPart += r;
                        rightCurrentBit += r;
                        remaining -= r;
                        rightCurrent++;
                        right.RightBytes.Add(0);

                        if (rightPeriodPart >= targetPeriodLength) // Needed to avoid the case of reaching target before this part
                            break;

                        b = (byte)(rightPeriodPart % 8);
                        r = (byte)General.Min(8 - b, remaining);
                        byte a = (byte)((b + r) % 8);
                        right.RightBytes[rightCurrent] |= (byte)((p.Bytes[(rightPeriodPart % right.PeriodLength) / 8] >> a) << (int)(rightPeriodPart % 8 - a));
                        rightPeriodPart += r;
                        rightCurrentBit += r;
                        remaining -= r;
                        rightCurrent++;
                    }
                }

                // Clean potential leftovers
                while (left.RightBytes.Last() == 0)
                    left.RightBytes.RemoveLast(1);
                while (right.RightBytes.Last() == 0)
                    right.RightBytes.RemoveLast(1);

                result.PeriodLength = targetPeriodLength;
            }
        }
        /// <summary>Parses a <seealso cref="string"/> as a <seealso cref="LargeDecimal"/>. Returns <see langword="true"/> if the string is a valid <seealso cref="LargeDecimal"/>, otherwise <see langword="false"/>.</summary>
        /// <param name="str">The string to parse.</param>
        /// <param name="result">The variable to return the converted <seealso cref="LargeDecimal"/> to.</param>
        public static bool TryParse(string str, out LargeDecimal result)
        {
            result = 0;
            try { result = Parse(str); }
            catch (FormatException) { return false; }
            return true;
        }
        /// <summary>Returns the relation between two <seealso cref="LargeDecimal"/>s. The result is the relation based on the left <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="a">The left <seealso cref="LargeDecimal"/> to compare.</param>
        /// <param name="b">The right <seealso cref="LargeDecimal"/> to compare.</param>
        public static Comparison GetRelation(LargeDecimal a, LargeDecimal b)
        {
            if (a < b)
                return Comparison.LessThan;
            else if (a == b)
                return Comparison.EqualTo;
            else
                return Comparison.GreaterThan;
            // Simple implementation, might need to optimize a bit
        }
        /// <summary>Gets the decimal digit count of the left part of a <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="l">The <seealso cref="LargeDecimal"/> whose decimal digit count on the left part to get.</param>
        public static long GetLeftDecimalDigitCount(LargeDecimal l) => LargeInteger.GetDecimalDigitCount(new LargeInteger(l.LeftBytes));
        /// <summary>Returns the average of a number of <seealso cref="LargeDecimal"/>s.</summary>
        /// <param name="a">The array of <seealso cref="LargeDecimal"/>s to calculate the average of.</param>
        public static LargeDecimal Average(params LargeDecimal[] l) => Sum(l) / l.Length;
        /// <summary>Returns the absolute value of a <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="l">The <seealso cref="LargeDecimal"/> whose absolute value to get.</param>
        public static LargeDecimal AbsoluteValue(LargeDecimal l) => l >= 0 ? l : -l;
        /// <summary>Calculates π using the Chudnovsky's formula with a specified number of terms to execute.</summary>
        /// <param name="n">The number of terms to execute.</param>
        public static LargeDecimal CalculatePi(LargeInteger n)
        {
            if (n > 0)
            {
                LargeInteger K = 6;
                LargeDecimal M = 1, L = 13591409, X = 0, S = 13591409;
                for (LargeInteger i = 1; i <= n; i++)
                {
                    M *= (LargeInteger.Power(K, 3) - 16 * K) / LargeInteger.Power(k + 1, 3);
                    L += 545140134;
                    X *= -262537412640768000;
                    S += M * L / X;
                    K += 12;
                }
                return 426880 * SquareRoot(10005, 50) / S;
            }
            else throw new ArgumentException();
        }
        /// <summary>Returns the value enclosed between the minimum specified value and the maximum specified value.</summary>
        /// <param name="min">The minimum specified value.</param>
        /// <param name="value">The value to enclose.</param>
        /// <param name="max">The maximum specified value.</param>
        public static LargeDecimal Clamp(LargeDecimal min, LargeDecimal value, LargeDecimal max)
        {
            if (min > max)
                throw new ArgumentException("Maximum value cannot be greater than minimum value.");
            if (min >= value)
                return min;
            if (value >= max)
                return max;
            return value;
        }
        /// <summary>Returns the exponentation of a <seealso cref="LargeDecimal"/> (e raised to a power).</summary>
        /// <param name="n">The <seealso cref="LargeDecimal"/> to raise e to.</param>
        public static LargeDecimal Exponentation(LargeDecimal n)
        {
            LargeDecimal result = 1;
            LargeDecimal previousResult = 0;
            LargeDecimal currentFactorial = 1;
            LargeDecimal currentPower = 1;
            LargeDecimal i = 1;
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
        /// <summary>Returns the binary logarithm (logarithm with base 2) of a <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="n">The <seealso cref="LargeDecimal"/> to find the binary logarithm of.</param>
        public static LargeDecimal Lb(LargeDecimal n)
        {
            if (n > 0) return Ln(n) / Ln(2);
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the natural logarithm (logarithm with base e) of a <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="n">The <seealso cref="LargeDecimal"/> to find the binary logarithm of.</param>
        public static LargeDecimal Ln(LargeDecimal n) // The process will be infinitely continuing for numbers with too much precision - Maybe consider optimizing or anything?
        {
            if (n > 0)
            {
                LargeDecimal t = (n - 1) / (n + 1);
                LargeDecimal result = t;
                LargeDecimal previousResult = 0;
                for (long i = 3; previousResult != result; i += 2)
                    result += Power(t, i) / i;
                return 2 * result;
            }
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base 10) of a <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="n">The <seealso cref="LargeDecimal"/> to find the binary logarithm of.</param>
        public static LargeDecimal Log(LargeDecimal n)
        {
            if (n > 0) return Ln(n) / Ln(10);
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base b) of a <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="n">The <seealso cref="LargeDecimal"/> to find the binary logarithm of.</param>
        public static LargeDecimal Log(LargeDecimal n, LargeDecimal b)
        {
            if (n > 0) return Ln(n) / Ln(n);
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the inverted value of the <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="l">The <seealso cref="LargeDecimal"/> to invert.</param>
        public static LargeDecimal Invert(LargeDecimal l) => 1 / l;
        /// <summary>Returns the largest <seealso cref="LargeDecimal"/> from an array of <seealso cref="LargeDecimal"/>s.</summary>
        /// <param name="n">The array of <seealso cref="LargeDecimal"/>s to get the largest <seealso cref="LargeDecimal"/> of.</param>
        public static LargeDecimal Max(params LargeDecimal[] n)
        {
            LargeDecimal max = n[0];
            for (int i = 1; i < n.Length; i++)
                if (max < n[i])
                    max = n[i];
            return max;
        }
        /// <summary>Returns the smallest <seealso cref="LargeDecimal"/> from an array of <seealso cref="LargeDecimal"/>s.</summary>
        /// <param name="n">The array of <seealso cref="LargeDecimal"/>s to get the smallest <seealso cref="LargeDecimal"/> of.</param>
        public static LargeDecimal Min(params LargeDecimal[] n)
        {
            LargeDecimal min = n[0];
            for (int i = 1; i < n.Length; i++)
                if (min > n[i])
                    min = n[i];
            return min;
        }
        /// <summary>Parses a <seealso cref="string"/> to its <seealso cref="LargeDecimal"/> representation.</summary>
        /// <param name="str">The <seealso cref="string"/> to parse as a <seealso cref="LargeDecimal"/>.</param>
        public static LargeDecimal Parse(string str)
        {
            LargeDecimal result = 0;
            LargeInteger e = 0;

            if (str[0] == '-') // If it's the negative sign symbol
            {
                str = str.Remove(0, 1);
                result.BoolSign = false;
            }

            str = str.ToLower(); // To ensure the potential "E" character is not in capital
            string[] s = str.Split('e');
            if (s.Length == 2)
                e = LargeInteger.Parse(s[1]);
            else if (s.Length != 1)
                throw new FormatException("The string is not a valid numerical value.");

            string[] split = s[0].Split('.');
            if (s[0].Length > 0 && split.Length <= 2)
            {
                string l = split[0];
                string r = split[1] ?? "";
                LargeDecimal currentPower = Power(10, l.Length - 1 + e);
                for (int i = l.Length - 1; i >= -r.Length; i--, currentPower /= 10)
                {
                    char c = i >= 0 ? l[i] : r[-i - 1];
                    if (c < '0' || c > '9') // If it's not a number character
                        throw new FormatException("The string is not a valid numerical value.");
                    result += (c - '0') * currentPower;
                }
            }
            else throw new FormatException("The string represents no numerical value.");

            return result;
        }
        /// <summary>Returns the product of a number of <seealso cref="LargeDecimal"/>s.</summary>
        /// <param name="a">The <seealso cref="LargeDecimal"/>s to calculate the product of.</param>
        public static LargeDecimal Product(params LargeDecimal[] a)
        {
            List<LargeDecimal> products = new List<LargeDecimal>(a);
            while (products.Count > 1)
            {
                for (int i = 0; i < a.Length - 1; i += 2)
                    products[i >> 1] = a[i] * a[i + 1];
                products.RemoveRange((a.Length + 1) / 2, a.Length / 2);
            }
            return products[0];
        }
        /// <summary>Calculates the power of a <seealso cref="LargeDecimal"/> raised to a <seealso cref="LargeInteger"/>.</summary>
        /// <param name="b">The base that will be raised to the power.</param>
        /// <param name="power">The power to raise the base to.</param>
        public static LargeDecimal Power(LargeDecimal b, LargeInteger power)
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
                    if (power.IsEven())
                        return Power(b * b, power << 1);
                    else
                        return Power(b * b, (power - 1) << 1);
                }
                else // if (power < 0)
                    return Power(1 / b, -power);
            }
            else if (power > 0)
                return 0;
            else if (power < 0)
                throw new DivideByZeroException("Cannot divide by zero. Elevating zero to a negative power is equal to dividing by zero raised to the absolute value of the power.");
            else
                throw new ElevateZeroToThePowerOfZeroException();
        }
        /// <summary>Calculates the power of a <seealso cref="LargeDecimal"/> raised to a <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="b">The base that will be raised to the power.</param>
        /// <param name="power">The power to raise the base to.</param>
        public static LargeDecimal Power(LargeDecimal b, LargeDecimal power) => Exponentation(power * Ln(b));
        /// <summary>Returns an approximation of the root of a <seealso cref="LargeDecimal"/>. The approximation is limited to a given number of decimal digits at most.</summary>
        /// <param name="b">The number whose square root to find.</param>
        /// <param name="rootClass">The class of the root.</param>
        /// <param name="decimalDigits">The number of decimal digits of the approximation.</param>
        public static LargeDecimal Root(LargeDecimal b, LargeInteger rootClass, long decimalDigits)
        {
            bool negative = b < 0;
            b.BoolSign = true; // Already checked if it's a negative number, needless to work around with the negative sign
            if (rootClass.IsEven() && negative)
                throw new Exception(); // EvenClassRootOfNegativeNumberException
            else if (b == Zero || b == One)
                return b;
            else if (b > 1)
            {
                long digCount = GetLeftDecimalDigitCount(b);
                long maxRootCount = digCount / 2 + 1;
                long minRootCount = General.Max((digCount / 2 - 1), 1);
                LargeDecimal start = Power(10, (minRootCount - 1));
                LargeDecimal end = Power(10, maxRootCount) - 1;
                LargeDecimal middle = (start + end) / 2;
                LargeDecimal power;
                while ((power = Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                middle.BoolSign = !negative;
                return middle;
            }
            else // if (0 < b < 1)
            {
                long digCount = GetLeftDecimalDigitCount(b);
                long maxRootCount = digCount / 2 + 1;
                long minRootCount = General.Max((digCount / 2 - 1), 1);
                LargeDecimal start = Power(10, (minRootCount - 1));
                LargeDecimal end = Power(10, maxRootCount) - 1;
                LargeDecimal middle = (start + end) / 2;
                LargeDecimal power;
                while ((power = Power(middle, rootClass)) != b && start <= end)
                {
                    if (power > b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                middle.BoolSign = !negative;
                return middle;
            }
        }
        /// <summary>Shifts the <seealso cref="LargeDecimal"/> to the left by a number of positions.</summary>
        /// <param name="left">The number to shift.</param>
        /// <param name="right">The positions to shift this number to.</param>
        public static LargeDecimal ShiftLeft(LargeDecimal left, long right)
        {
            // TODO: Work on this by changing some details in the operation
            LargeDecimal result = left;
            int shifts = (int)(right % 8);
            long fullShifts = right / 8;
            for (long i = 0; i < fullShifts; i++)
                result.LeftBytes.Add(result.LeftBytes[i - fullShifts]);
            if (fullShifts > 0)
            {
                for (long i = result.LeftLength - 1; i > 0; i--)
                    result.LeftBytes[i] = result.LeftBytes[i - 1];
                if (result.RightLength > 0)
                {
                    result.LeftBytes[0] = result.RightBytes[0];
                    for (long i = 0; i < result.RightLength - 1; i++)
                        result.RightBytes[i] = result.RightBytes[i + 1];
                }
                if (fullShifts <= result.RightLength)
                    result.RightBytes.RemoveLast(fullShifts);
                else
                {
                    fullShifts -= result.RightLength;
                    result.RightBytes.Clear();
                    result.LeftBytes.RemoveLast(fullShifts);
                }
            }
            if (shifts > 0)
            {
                for (long i = result.LeftLength - 1; i > 0; i--)
                    result.LeftBytes[i] = (byte)((result.LeftBytes[i - 1] >> (8 - shifts) + (result.LeftBytes[i] << shifts)));
                if (result.RightLength > 0)
                {
                    result.LeftBytes[0] = (byte)((result.RightBytes[0] >> (8 - shifts) + (result.LeftBytes[0] << shifts))); // Shift the bytes between the decimal point
                    for (long i = 0; i < result.RightLength - 1; i++)
                        result.RightBytes[i] = (byte)((result.RightBytes[i + 1] >> (8 - shifts) + (result.RightBytes[i] << shifts)));
                    result.RightBytes[result.RightLength - 1] = (byte)(result.RightBytes[result.RightLength - 1] << shifts);
                }
            }
            return result;
        }
        /// <summary>Shifts the <seealso cref="LargeDecimal"/> to the right by a number of positions.</summary>
        /// <param name="left">The number to shift.</param>
        /// <param name="right">The positions to shift this number to.</param>
        public static LargeDecimal ShiftRight(LargeDecimal left, long right)
        {
            LargeDecimal result = left;
            int shifts = (int)(right % 8);
            long fullShifts = right / 8;
            for (long i = 0; i < fullShifts; i++)
                result.RightBytes.Add(result.RightBytes[i - fullShifts]);
            if (fullShifts > 0)
            {
                for (long i = result.RightLength - 1; i > 0; i--)
                    result.RightBytes[i] = result.RightBytes[i - 1];
                if (result.LeftLength > 0)
                {
                    result.RightBytes[0] = result.LeftBytes[0];
                    for (long i = 0; i < result.LeftLength - 1; i++)
                        result.LeftBytes[i] = result.LeftBytes[i + 1];
                }
                if (fullShifts <= result.LeftLength)
                    result.LeftBytes.RemoveLast(fullShifts);
                else
                {
                    fullShifts -= result.LeftLength;
                    result.LeftBytes.Clear();
                    result.RightBytes.RemoveLast(fullShifts);
                }
            }
            if (shifts > 0)
            {
                for (long i = result.RightLength - 1; i > 0; i--)
                    result.RightBytes[i] = (byte)((result.RightBytes[i - 1] << (8 - shifts) + (result.RightBytes[i] >> shifts)));
                if (result.LeftLength > 0)
                {
                    result.RightBytes[0] = (byte)((result.LeftBytes[0] << (8 - shifts) + (result.RightBytes[0] >> shifts))); // Shift the bytes between the decimal point
                    for (long i = 0; i < result.LeftLength - 1; i++)
                        result.LeftBytes[i] = (byte)((result.LeftBytes[i + 1] << (8 - shifts) + (result.LeftBytes[i] >> shifts)));
                    result.LeftBytes[result.LeftLength - 1] = (byte)(result.LeftBytes[result.LeftLength - 1] >> shifts);
                }
            }
            return result;
        }
        /// <summary>Returns the sum of a number of <seealso cref="LargeDecimal"/>s.</summary>
        /// <param name="a">The <seealso cref="LargeDecimal"/>s to calculate the sum of.</param>
        public static LargeDecimal Sum(params LargeDecimal[] a)
        {
            List<LargeDecimal> sums = new List<LargeDecimal>(a);
            while (sums.Count > 1)
            {
                for (int i = 0; i < a.Length - 1; i += 2)
                    sums[i >> 1] = a[i] + a[i + 1];
                sums.RemoveRange((a.Length + 1) / 2, a.Length / 2);
            }
            return sums[0];
        }
        /// <summary>Returns an approximation of the square root of a <seealso cref="LargeDecimal"/>. The approximation is limited to a given number of decimal digits at most.</summary>
        /// <param name="b">The number whose square root to find.</param>
        /// <param name="decimalDigits">The number of decimal digits of the approximation.</param>
        public static LargeDecimal SquareRoot(LargeDecimal b, int decimalDigits) => Root(b, 2, decimalDigits);
        #endregion
        #region Accessors
        /// <summary>Returns the byte at the specified index in the appropriate collection.</summary>
        /// <param name="index">The index of the byte. A non-negative index ([0, <seealso cref="long.MaxValue"/>]) will access the left bytes while a strictly negative index ([<seealso cref="long.MinValue"/>, -1]) will return the byte at the respective index of the right bytes.</param>
        public byte this[long index]
        {
            get => index < 0 ? RightBytes[-index - 1] : LeftBytes[index];
            set
            {
                if (index < 0)
                    RightBytes[-index - 1] = value;
                else
                    LeftBytes[index] = value;
            }
        }
        #endregion
        #region Overrides
        /// <summary>Returns the <seealso cref="string"/> representation of the <seealso cref="LargeDecimal"/>.</summary>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (Sign == Sign.Negative)
                result.Append("-");
            LargeInteger rightIntPart = new LargeInteger();
            rightIntPart.Bytes = RightBytes;
            LargeInteger leftIntPart = new LargeInteger();
            leftIntPart.Bytes = LeftBytes;
            LargeInteger currentIntPart;
            for (LargeInteger i = 1; (currentIntPart = leftIntPart / i) > 0; i *= 10)
                result.Insert(0, (char)((currentIntPart % 10) + 48));
            if (rightIntPart > 0)
            {
                result.Append(".");
                long index = result.Length;
                for (LargeInteger i = 1; (currentIntPart = rightIntPart / i) > 0; i *= 10)
                    result.Insert(index, (char)((currentIntPart % 10) + 48));
            }
            return result.ToString();
        }
        /// <summary>Returns a value indicating whether a <seealso cref="LargeDecimal"/> is equal to another.</summary>
        /// <param name="obj">The object to check whether the <seealso cref="LargeDecimal"/> is equal to.</param>
        public override bool Equals(object obj) => (LargeDecimal)obj == this;
        /// <summary>Returns the hash code of the <seealso cref="LargeDecimal"/>.</summary>
        public override int GetHashCode() => base.GetHashCode();
        #endregion
    }
}