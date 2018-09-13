using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.Tools;
using EML.Tools.Enumerations;
using EML.Exceptions;
using EML.Extensions;

namespace EML.NumericTypes
{
    /// <summary>Represents an arbitrarily large decimal number.</summary>
    public struct LargeDecimal
    {
        /// <summary>The <seealso cref="byte"/> list representing the digits on the left side of the number from the decimal point (the integral part).</summary>
        public LongList<byte> LeftBytes { get; set; } // The bytes for the left part of the decimal number
        /// <summary>The <seealso cref="byte"/> list representing the digits on the right side of the number from the decimal point (the decimal part).</summary>
        public LongList<byte> RightBytes { get; set; } // The bytes for the right part of the decimal number (after the decimal point)
        /// <summary>The <seealso cref="Tools.Enumerations.Sign"/> of the <seealso cref="LargeDecimal"/>.</summary>
        public Sign Sign { get; set; }
        /// <summary>The sign of the <seealso cref="LargeDecimal"/> as a <seealso cref="bool"/>. If the sign is positive, this value is <see langword="true"/>, otherwise <see langword="false"/>.</summary>
        public bool BoolSign
        {
            get => Sign == Sign.Positive;
            set => Sign = value ? Sign.Positive : Sign.Negative;
        }
        //public int Length { get { return LeftBytes.Count + RightBytes.Count; } }
        /// <summary>The length of the left part of the instance of <seealso cref="LargeDecimal"/>.</summary>
        public long LeftLength { get { return LeftBytes.Count; } }
        /// <summary>The length of the right part of the instance of <seealso cref="LargeDecimal"/>.</summary>
        public long RightLength { get { return RightBytes.Count; } }
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
        public LargeDecimal(byte b, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>();
            LeftBytes.Add(b);
            RightBytes = new LongList<byte>();
            Sign = Sign.Positive;
            PeriodLength = 0;
        }
        public LargeDecimal(short s, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>();
            LeftBytes.AddRange(BitConverter.GetBytes(General.AbsoluteValue(s)));
            RightBytes = new LongList<byte>();
            Sign = s >= 0 ? Sign.Positive : Sign.Negative;
            PeriodLength = 0;
        }
        public LargeDecimal(int i, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>();
            LeftBytes.AddRange(BitConverter.GetBytes(General.AbsoluteValue(i)));
            RightBytes = new LongList<byte>();
            Sign = i >= 0 ? Sign.Positive : Sign.Negative;
            PeriodLength = 0;
        }
        public LargeDecimal(long l, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>();
            LeftBytes.AddRange(BitConverter.GetBytes(General.AbsoluteValue(l)));
            RightBytes = new LongList<byte>();
            Sign = l >= 0 ? Sign.Positive : Sign.Negative;
            PeriodLength = 0;
        }
        public LargeDecimal(sbyte b, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>();
            LeftBytes.Add((byte)General.AbsoluteValue(b));
            RightBytes = new LongList<byte>();
            Sign = b >= 0 ? Sign.Positive : Sign.Negative;
            PeriodLength = 0;
        }
        public LargeDecimal(ushort s, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>();
            LeftBytes.AddRange(BitConverter.GetBytes(s));
            RightBytes = new LongList<byte>();
            Sign = Sign.Positive;
            PeriodLength = 0;
        }
        public LargeDecimal(uint i, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>();
            LeftBytes.AddRange(BitConverter.GetBytes(i));
            RightBytes = new LongList<byte>();
            Sign = Sign.Positive;
            PeriodLength = 0;
        }
        public LargeDecimal(ulong l, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>();
            LeftBytes.AddRange(BitConverter.GetBytes(l));
            RightBytes = new LongList<byte>();
            Sign = Sign.Positive;
            PeriodLength = 0;
        }
        public LargeDecimal(float f, bool removeUnnecessaryBytes = true)
        {
            LargeDecimal a = Parse(f.ToString());
            LeftBytes = a.LeftBytes;
            RightBytes = a.RightBytes;
            Sign = a.Sign;
            PeriodLength = 0;
        }
        public LargeDecimal(double d, bool removeUnnecessaryBytes = true)
        {
            LargeDecimal a = Parse(d.ToString());
            LeftBytes = a.LeftBytes;
            RightBytes = a.RightBytes;
            Sign = a.Sign;
            PeriodLength = 0;
        }
        public LargeDecimal(decimal d, bool removeUnnecessaryBytes = true)
        {
            LargeDecimal a = Parse(d.ToString());
            LeftBytes = a.LeftBytes;
            RightBytes = a.RightBytes;
            Sign = a.Sign;
            PeriodLength = 0;
        }
        public LargeDecimal(LargeInteger l, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = l.Bytes;
            RightBytes = new LongList<byte>();
            Sign = l.Sign;
            PeriodLength = 0;
        }
        public LargeDecimal(byte[] leftBytes, byte[] rightBytes, bool removeUnnecessaryBytes = true)
        {
            LeftBytes = new LongList<byte>();
            LeftBytes.AddRange(leftBytes);
            RightBytes = new LongList<byte>();
            RightBytes.AddRange(rightBytes);
            Sign = Sign.Positive;
            PeriodLength = 0;
        }
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

            // If both numbers are repeating, expand them accordingly to calculate the repeating part
            if ((left.PeriodLength | right.PeriodLength) > 0)
            {
                byte leftLast = left.GetLastDecimalBitIndex();
                byte rightLast = right.GetLastDecimalBitIndex();

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

                long targetPeriodLength;
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

            return RemoveUnnecessaryBytes(result);
        }
        public static LargeDecimal operator -(LargeDecimal left, LargeDecimal right) => left + (-right);
        public static LargeDecimal operator *(LargeDecimal left, LargeDecimal right)
        {
            // TODO: Work on this, add some details in the algorithm
            LargeDecimal result = 0;
            result.BoolSign = left.Sign == right.Sign;
            left = AbsoluteValue(left);
            right = AbsoluteValue(right);
            while (right > 0)
            {
                LargeDecimal temp = (right >> 1) << 1;
                if (temp != right) result += left;
                left <<= 1;
                right >>= 1;
            }
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
                if (AbsoluteValue(left) == AbsoluteValue(right))
                    return (int)SignFunctions.Multiply(left.Sign, right.Sign);
                else
                {
                    LargeInteger leftInt = new LargeInteger(ShiftLeft(left, left.RightLength * 8));
                    LargeInteger rightInt = new LargeInteger(ShiftLeft(right, right.RightLength * 8));
                    LargeDecimal result = 0;
                    result.Sign = SignFunctions.Multiply(left.Sign, right.Sign);
                    leftInt = LargeInteger.AbsoluteValue(leftInt);
                    rightInt = LargeInteger.AbsoluteValue(rightInt);
                    LargeInteger numBits = leftInt.Length * 8;
                    LargeInteger t, q, bit, d = 0;
                    LargeInteger remainder = 0;
                    while (remainder < rightInt)
                    {
                        bit = LargeInteger.ShiftRight(leftInt & LargeInteger.ShiftLeft(1, leftInt.Length * 8 - 1), leftInt.Length * 8 - 1);
                        remainder = (remainder << 1) | bit;
                        d = leftInt;
                        leftInt <<= 1;
                        numBits--;
                    }

                    /* The loop, above, always goes one iteration too far.
                       To avoid inserting an "if" statement inside the loop
                       the last iteration is simply reversed. */

                    leftInt = d;
                    remainder = remainder >> 1;
                    numBits++;

                    for (LargeInteger i = 0; i < numBits; i++)
                    {
                        bit = LargeInteger.ShiftRight(leftInt & LargeInteger.ShiftLeft(1, leftInt.Length * 8 - 1), leftInt.Length * 8 - 1);
                        remainder = (remainder << 1) | bit;
                        t = remainder - rightInt;
                        q = ~LargeInteger.ShiftRight(t & LargeInteger.ShiftLeft(1, t.Length * 8 - 1), t.Length * 8 - 1);
                        leftInt <<= 1;
                        result = (result << 1) | q;
                        if (q != 0)
                            remainder = t;
                        // Check here if the result is periodic
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
            long minLeftLength = General.Min(left.LeftLength, right.LeftLength);
            long minRightLength = General.Min(left.RightLength, right.RightLength);
            long maxLeftLength = General.Max(left.LeftLength, right.LeftLength);
            long maxRightLength = General.Max(left.RightLength, right.RightLength);
            byte[] leftBytes = new byte[minLeftLength];
            byte[] rightBytes = new byte[minRightLength];
            for (long i = 0; i < minLeftLength; i++)
                leftBytes[i] = (byte)(left.LeftBytes[i] | right.LeftBytes[i]);
            for (long i = 0; i < minRightLength; i++)
                rightBytes[i] = (byte)(left.RightBytes[i] | right.RightBytes[i]);
            if (left.LeftLength > right.LeftLength)
                for (long i = minLeftLength; i < maxLeftLength; i++)
                    leftBytes[i] = left.LeftBytes[i];
            else
                for (long i = minLeftLength; i < maxLeftLength; i++)
                    leftBytes[i] = right.LeftBytes[i];
            if (right.RightLength > right.RightLength)
                for (long i = minRightLength; i < maxRightLength; i++)
                    rightBytes[i] = right.RightBytes[i];
            else
                for (long i = minRightLength; i < maxRightLength; i++)
                    rightBytes[i] = right.RightBytes[i];
            return new LargeDecimal(leftBytes, rightBytes);
        }
        public static LargeDecimal operator ^(LargeDecimal left, LargeDecimal right)
        {
            long minLeftLength = General.Min(left.LeftLength, right.LeftLength);
            long minRightLength = General.Min(left.RightLength, right.RightLength);
            long maxLeftLength = General.Max(left.LeftLength, right.LeftLength);
            long maxRightLength = General.Max(left.RightLength, right.RightLength);
            byte[] leftBytes = new byte[minLeftLength];
            byte[] rightBytes = new byte[minRightLength];
            for (long i = 0; i < minLeftLength; i++)
                leftBytes[i] = (byte)(left.LeftBytes[i] ^ right.LeftBytes[i]);
            for (long i = 0; i < minRightLength; i++)
                rightBytes[i] = (byte)(left.RightBytes[i] ^ right.RightBytes[i]);
            if (left.LeftLength > right.LeftLength)
                for (long i = minLeftLength; i < maxLeftLength; i++)
                    leftBytes[i] = left.LeftBytes[i];
            else
                for (long i = minLeftLength; i < maxLeftLength; i++)
                    leftBytes[i] = right.LeftBytes[i];
            if (right.RightLength > right.RightLength)
                for (long i = minRightLength; i < maxRightLength; i++)
                    rightBytes[i] = right.RightBytes[i];
            else
                for (long i = minRightLength; i < maxRightLength; i++)
                    rightBytes[i] = right.RightBytes[i];
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
            if (left.LeftLength != right.LeftLength)
                return false;
            else if (left.RightLength != right.RightLength)
                return false;
            else
            {
                for (long i = 0; i < left.LeftLength; i++)
                    if (left.LeftBytes[i] != right.LeftBytes[i])
                        return false;
                for (long i = 0; i < left.RightLength; i++)
                    if (left.RightBytes[i] != right.RightBytes[i])
                        return false;
                return left.PeriodLength == left.RightLength;
            }
        }
        public static bool operator !=(LargeDecimal left, LargeDecimal right)
        {
            if (left.LeftLength != right.LeftLength)
                return true;
            else if (left.RightLength != right.RightLength)
                return true;
            else
            {
                for (long i = 0; i < left.LeftLength; i++)
                    if (left.LeftBytes[i] != right.LeftBytes[i])
                        return true;
                for (long i = 0; i < left.RightLength; i++)
                    if (left.RightBytes[i] != right.RightBytes[i])
                        return true;
                return left.PeriodLength != left.RightLength;
            }
        }
        #endregion
        #region Constants
        // The constant values are converted to sbytes so as to minimize the cost of removing bytes
        /// <summary>Represents the number 0.</summary>
        public static readonly LargeDecimal Zero = new LargeDecimal((byte)0);
        /// <summary>Represents the number 1.</summary>
        public static readonly LargeDecimal One = new LargeDecimal((byte)1);
        /// <summary>Represents the number -1.</summary>
        public static readonly LargeDecimal NegativeOne = new LargeDecimal((sbyte)-1);
        #endregion
        #region Operations
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
        internal byte GetLastDecimalBitIndex()
        {
            byte result = 7;
            byte last = LeftBytes.Last();
            while ((last << result) >> 8 == 0)
                result--;
            return result;
        }
        /// <summary>Gets the selected bit at the specified index of the left bytes of this <seealso cref="LargeDecimal"/> as a <seealso cref="byte"/>.</summary>
        /// <param name="index">The index of the bit.</param>
        public byte GetLeftBitAt(long index) => (byte)((LeftBytes[index / 8] << (int)(8 - index % 8)) >> (int)(index % 8));
        /// <summary>Gets the selected bit at the specified index of the right bytes of this <seealso cref="LargeDecimal"/> as a <seealso cref="byte"/>.</summary>
        /// <param name="index">The index of the bit.</param>
        public byte GetRightBitAt(long index) => (byte)((RightBytes[index / 8] << (int)(8 - index % 8)) >> (int)(index % 8));
        #endregion
        #region Static Operations
        /// <summary>Parses a <seealso cref="string"/> as an instance of <seealso cref="LargeDecimal"/>. Returns <see langword="true"/> if the string is valid <seealso cref="LargeDecimal"/>, otherwise <see langword="false"/>.</summary>
        /// <param name="str">The string to parse.</param>
        /// <param name="result">The variable to return the converted instance of <seealso cref="LargeDecimal"/> to.</param>
        public static bool TryParse(string str, out LargeDecimal result)
        {
            result = 0;
            try { result = Parse(str); }
            catch (FormatException) { return false; }
            return true;
        }
        /// <summary>Returns the relation between two instances of <seealso cref="LargeDecimal"/>. The result is the relation based on the left <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="a">The left instance of <seealso cref="LargeDecimal"/> to compare.</param>
        /// <param name="b">The right instance of <seealso cref="LargeDecimal"/> to compare.</param>
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
        /// <summary>Gets the decimal digit count of an instance of <seealso cref="LargeDecimal"/> (the decimal point does not count as part of the digit count).</summary>
        /// <param name="l">The <seealso cref="LargeDecimal"/> whose decimal digits to get.</param>
        public static long GetDecimalDigitCount(LargeDecimal l)
        {
            LargeInteger leftBytes = new LargeInteger(l.LeftBytes);
            LargeInteger rightBytes = new LargeInteger(l.RightBytes);
            int shifts = 0;
            int power = 10;
            while (rightBytes % power == 0)
            {
                shifts++;
                power *= 10;
            }
            rightBytes >>= shifts;
            return LargeInteger.GetDecimalDigitCount(leftBytes) + LargeInteger.GetDecimalDigitCount(rightBytes);
        }
        /// <summary>Returns the average of a number of instances of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="a">The array of instances of <seealso cref="LargeInteger"/> to calculate the average of.</param>
        public static LargeDecimal Average(params LargeDecimal[] l) => Sum(l) / l.Length;
        /// <summary>Returns the absolute value of a <seealso cref="LargeInteger"/>.</summary>
        /// <param name="l">The <seealso cref="LargeInteger"/> whose absolute value to get.</param>
        public static LargeDecimal AbsoluteValue(LargeDecimal l) => l >= 0 ? l : -l;
        /// <summary>Calculates π using the Chudnovsky's formula with a specified number of terms to execute.</summary>
        /// <param name="n">The number of terms to execute.</param>
        public static LargeDecimal CalculatePi(LargeInteger n)
        {
            if (n > 0)
            {
                LargeDecimal result = 0;
                for (LargeInteger i = 0; i <= n; i++)
                    result += (LargeInteger.Factorial(6 * i) * (545140134 * i + 13591409)) / (LargeDecimal)(LargeInteger.Factorial(3 * i) * LargeInteger.Power(LargeInteger.Factorial(i), 3) * LargeInteger.Power(-262537412640768000, i));
                return 426880 * SquareRoot(10005, 50) / result;
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
            if (min == max)
                return min;
            if (min > value)
                return min;
            if (value > max)
                return max;
            return value;
        }
        /// <summary>Returns the exponentation of a number (e raised to a power).</summary>
        /// <param name="n">The number to raise e.</param>
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
        /// <summary>Returns the binary logarithm (logarithm with base 2) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static LargeDecimal Lb(LargeDecimal n)
        {
            if (n > 0) return Ln(n) / Ln(2);
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the natural logarithm (logarithm with base e) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static LargeDecimal Ln(LargeDecimal n) // The process will be infinitely continuing for numbers with too much precision - Maybe consider optimizing or anything?
        {
            if (n > 0)
            {
                LargeDecimal t = (n - 1) / (n + 1);
                LargeDecimal result = t;
                LargeDecimal previousResult = 0;
                for (int i = 3; previousResult != result; i += 2)
                    result += Power(t, i) / i;
                return 2 * result;
            }
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base 10) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static LargeDecimal Log(LargeDecimal n)
        {
            if (n > 0) return Ln(n) / Ln(10);
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the binary logarithm (logarithm with base b) of a number.</summary>
        /// <param name="n">The number to find the binary logarithm of.</param>
        public static LargeDecimal Log(LargeDecimal n, LargeDecimal b)
        {
            if (n > 0) return Ln(n) / Ln(n);
            else throw new Exception(); // LogarithmOfNonPositiveNumberException
        }
        /// <summary>Returns the inverted value of the <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="l">The <seealso cref="LargeDecimal"/> to invert.</param>
        public static LargeDecimal Invert(LargeDecimal l) => 1 / l;
        /// <summary>Returns the largest <seealso cref="LargeDecimal"/> from an array of instances of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="n">The array of instances of <seealso cref="LargeDecimal"/> to get the largest <seealso cref="LargeDecimal"/> of.</param>
        public static LargeDecimal Max(params LargeDecimal[] n)
        {
            LargeDecimal max = n[0];
            for (int i = 1; i < n.Length; i++)
                if (max < n[i])
                    max = n[i];
            return max;
        }
        /// <summary>Returns the smallest <seealso cref="LargeDecimal"/> from an array of instances of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="n">The array of instances of <seealso cref="LargeDecimal"/> to get the smallest <seealso cref="LargeDecimal"/> of.</param>
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
            if (str[0] == '-') // If it's the negative sign symbol
            {
                str = str.Remove(0, 1);
                result.BoolSign = false;
            }
            string[] split = str.Split('.');
            if (str.Length > 0 && split.Length <= 2)
            {
                result.LeftBytes = LargeInteger.Parse(split[0]).Bytes;
                for (int i = 0; i < split[1].Length; i++)
                    if (str[i] < '0' || str[i] > '9') // If it's not a number character
                        throw new FormatException("The string is not a valid numerical value.");
                for (int i = split[0].Length - 1; i >= 0; i--)
                    result += split[0][i] * Power(10, i - split[0].Length + 1);
            }
            else throw new FormatException("The string represents no numerical value.");
            return result;
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
        /// <summary>Removes the useless null bytes in the <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="l">The <seealso cref="LargeDecimal"/> to remove the useless null bytes of.</param>
        private static LargeDecimal RemoveUnnecessaryBytes(LargeDecimal l)
        {
            long i = 0;
            while (i < l.LeftLength && l.LeftBytes[l.LeftBytes.Count - i - 1] == 0)
                i++;
            l.LeftBytes.RemoveLast(i);
            i = 0;
            while (i < l.RightLength && l.RightBytes[l.RightBytes.Count - i - 1] == 0)
                i++;
            l.RightBytes.RemoveLast(i);
            return l;
        }
        /// <summary>Returns an approximation of the root of a number. The approximation is limited to a given number of decimal digits at most.</summary>
        /// <param name="b">The number whose square root to find.</param>
        /// <param name="rootClass">The class of the root.</param>
        /// <param name="decimalDigits">The number of decimal digits of the approximation.</param>
        public static LargeDecimal Root(LargeDecimal b, LargeInteger rootClass, int decimalDigits)
        {
            bool negative = b < 0;
            b.BoolSign = true; // Already checked if it's a negative number, needless to work around with the stupid negative sign
            if (b == 0 || b == 1) return b;
            else if (((rootClass & 1) == 0) && negative) throw new Exception(); // EvenClassRootOfNegativeNumberException
            else if (b > 1)
            {
                long digCount = GetDecimalDigitCount(b);
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
                long digCount = GetDecimalDigitCount(b);
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
        /// <summary>Returns the sum of a number of instances of <seealso cref="LargeDecimal"/>.</summary>
        /// <param name="a">The array of instances of <seealso cref="LargeDecimal"/> to calculate the sum of.</param>
        public static LargeDecimal Sum(params LargeDecimal[] a)
        {
            LargeDecimal result = 0;
            for (int i = 0; i < a.Length; i++)
                result += a[i];
            return result;
        }
        /// <summary>Returns an approximation of the square root of a number. The approximation is limited to a given number of decimal digits at most.</summary>
        /// <param name="b">The number whose square root to find.</param>
        /// <param name="decimalDigits">The number of decimal digits of the approximation.</param>
        public static LargeDecimal SquareRoot(LargeDecimal b, int decimalDigits) => Root(b, 2, decimalDigits);
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
            rightIntPart.Bytes = LeftBytes;
            LargeInteger currentIntPart = leftIntPart;
            for (LargeInteger i = 1; (currentIntPart = leftIntPart / i) > 0; i *= 10)
                result.Insert(0, (char)((currentIntPart % 10) + 48));
            if (rightIntPart > 0)
            {
                result.Append(".");
                for (LargeInteger i = 1; (currentIntPart = rightIntPart / i) > 0; i *= 10)
                    result.Append((char)((currentIntPart % 10) + 48));
            }
            return result.ToString();
        }
        /// <summary>Returns a value indicating whether an object is equal to another.</summary>
        /// <param name="obj">The object to check whether the instance of <seealso cref="LargeDecimal"/> is equal to.</param>
        public override bool Equals(object obj) => (LargeDecimal)obj == this;
        // Get this fucking code copy-pasted bitch
        /// <summary>Returns the hash code of the <seealso cref="LargeDecimal"/>.</summary>
        public override int GetHashCode() => base.GetHashCode();
        // I love copy-pasting my useless code everywhere because of someone being idiotic
        #endregion
    }
}