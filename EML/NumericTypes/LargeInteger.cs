﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    /// <summary>Represents an arbitrarily large integer.</summary>
    public struct LargeInteger
    {
        /// <summary>The <seealso cref="byte"/> list representing the digits of the number.</summary>
        public List<byte> Bytes { get; set; }
        /// <summary>The sign of the instance of <seealso cref="LargeInteger"/>. If the sign is positive, this value is <see langword="true"/>, otherwise <see langword="false"/>.</summary>
        public bool Sign { get; set; } // True if number is positive
        /// <summary>The length of the instance of <seealso cref="LargeInteger"/>.</summary>
        public int Length => Bytes.Count;

        #region Constructors
        /// <summary>Creates a new instance of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="b">The <seealso cref="byte"/> value to create the <seealso cref="LargeInteger"/> from.</param>
        public LargeInteger(byte b)
        {
            Bytes = new List<byte>();
            Bytes.Add(b);
            Sign = true;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="b">The <seealso cref="short"/> value to create the <seealso cref="LargeInteger"/> from.</param>
        public LargeInteger(short s)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes(General.AbsoluteValue(s)));
            Sign = s >= 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="b">The <seealso cref="int"/> value to create the <seealso cref="LargeInteger"/> from.</param>
        public LargeInteger(int i)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes(General.AbsoluteValue(i)));
            Sign = i >= 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="b">The <seealso cref="long"/> value to create the <seealso cref="LargeInteger"/> from.</param>
        public LargeInteger(long l)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes(General.AbsoluteValue(l)));
            Sign = l >= 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="b">The <seealso cref="sbyte"/> value to create the <seealso cref="LargeInteger"/> from.</param>
        public LargeInteger(sbyte b)
        {
            Bytes = new List<byte>();
            Bytes.Add((byte)General.AbsoluteValue(b));
            Sign = b >= 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="b">The <seealso cref="ushort"/> value to create the <seealso cref="LargeInteger"/> from.</param>
        public LargeInteger(ushort s)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes(s));
            Sign = s >= 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="b">The <seealso cref="uint"/> value to create the <seealso cref="LargeInteger"/> from.</param>
        public LargeInteger(uint i)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes(i));
            Sign = i >= 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="b">The <seealso cref="ulong"/> value to create the <seealso cref="LargeInteger"/> from.</param>
        public LargeInteger(ulong l)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes(l));
            Sign = l >= 0;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="b">The <seealso cref="float"/> value to create the <seealso cref="LargeInteger"/> from.</param>
        public LargeInteger(float f)
        {
            LargeInteger n = Parse(f.ToString());
            Bytes = n.Bytes;
            Sign = n.Sign;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="b">The <seealso cref="double"/> value to create the <seealso cref="LargeInteger"/> from.</param>
        public LargeInteger(double d)
        {
            LargeInteger n = Parse(d.ToString());
            Bytes = n.Bytes;
            Sign = n.Sign;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="b">The <seealso cref="decimal"/> value to create the <seealso cref="LargeInteger"/> from.</param>
        public LargeInteger(decimal d)
        {
            LargeInteger n = Parse(d.ToString());
            Bytes = n.Bytes;
            Sign = n.Sign;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="b">The <seealso cref="LargeDecimal"/> value to create the <seealso cref="LargeInteger"/> from.</param>
        public LargeInteger(LargeDecimal d)
        {
            Bytes = d.RightBytes;
            Sign = d.Sign;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="b">The <seealso cref="byte"/> array to create the <seealso cref="LargeInteger"/> from.</param>
        public LargeInteger(byte[] b)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(b);
            Sign = true;
        }
        /// <summary>Creates a new instance of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="b">The <seealso cref="byte"/> list to create the <seealso cref="LargeInteger"/> from.</param>
        public LargeInteger(List<byte> b)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(b);
            Sign = true;
        }
        #endregion
        #region Implicit Conversions
        public static implicit operator LargeInteger(byte a) => new LargeInteger(a);
        public static implicit operator LargeInteger(short a) => new LargeInteger(a);
        public static implicit operator LargeInteger(int a) => new LargeInteger(a);
        public static implicit operator LargeInteger(long a) => new LargeInteger(a);
        public static implicit operator LargeInteger(sbyte a) => new LargeInteger(a);
        public static implicit operator LargeInteger(ushort a) => new LargeInteger(a);
        public static implicit operator LargeInteger(uint a) => new LargeInteger(a);
        public static implicit operator LargeInteger(ulong a) => new LargeInteger(a);
        #endregion
        #region Explicit Conversions
        public static explicit operator LargeInteger(float a) => new LargeInteger(a);
        public static explicit operator LargeInteger(double a) => new LargeInteger(a);
        public static explicit operator LargeInteger(decimal a) => new LargeInteger(a);
        public static explicit operator LargeInteger(LargeDecimal a) => new LargeInteger(a);
        #endregion
        #region Type Casts
        public static explicit operator byte(LargeInteger a)
        {
            if (a.Length == 1) return a.Bytes[0];
            else throw new OverflowException("The LargeInteger was too big.");
        }
        public static explicit operator sbyte(LargeInteger a)
        {
            if (a.Length == 1) return (sbyte)a.Bytes[0];
            else throw new OverflowException("The LargeInteger was too big.");
        }
        public static explicit operator short(LargeInteger a)
        {
            if (a.Length <= 2) return BitConverter.ToInt16(a.Bytes.ToArray(), 0);
            else throw new OverflowException("The LargeInteger was too big.");
        }
        public static explicit operator int(LargeInteger a)
        {
            if (a.Length <= 4) return BitConverter.ToInt32(a.Bytes.ToArray(), 0);
            else throw new OverflowException("The LargeInteger was too big.");
        }
        public static explicit operator long(LargeInteger a)
        {
            if (a.Length <= 8) return BitConverter.ToInt64(a.Bytes.ToArray(), 0);
            else throw new OverflowException("The LargeInteger was too big.");
        }
        public static explicit operator ushort(LargeInteger a)
        {
            if (a.Length <= 2) return BitConverter.ToUInt16(a.Bytes.ToArray(), 0);
            else throw new OverflowException("The LargeInteger was too big.");
        }
        public static explicit operator uint(LargeInteger a)
        {
            if (a.Length <= 4) return BitConverter.ToUInt32(a.Bytes.ToArray(), 0);
            else throw new OverflowException("The LargeInteger was too big.");
        }
        public static explicit operator ulong(LargeInteger a)
        {
            if (a.Length <= 8) return BitConverter.ToUInt64(a.Bytes.ToArray(), 0);
            else throw new OverflowException("The LargeInteger was too big.");
        }
        public static explicit operator float(LargeInteger a)
        {
            // Obviously not the most optimal way to go, but I'm not gonna bother unless someone implements those structures more developer-friendly
            try
            {
                float result = 0;
                for (int i = a.Bytes.Count - 1; i > General.Max(a.Bytes.Count - 4, 0); i--)
                    result += a.Bytes[i] * (float)General.Power(2, i * 8);
                result = result * (a < 0 ? -1 : 1);
                return result;
            }
            catch { throw new OverflowException("The LargeInteger was too big."); } // Really, brackets are not necessary for single-line statements
        }
        public static explicit operator double(LargeInteger a)
        {
            // Obviously not the most optimal way to go, but I'm not gonna bother unless someone implements those structures more developer-friendly
            try
            {
                double result = 0;
                for (int i = a.Bytes.Count - 1; i > General.Max(a.Bytes.Count - 8, 0); i--)
                    result += a.Bytes[i] * General.Power(2, i * 8);
                result = result * (a < 0 ? -1 : 1);
                return result;
            }
            catch { throw new OverflowException("The LargeInteger was too big."); } // Really, brackets are not necessary for single-line statements
        }
        public static explicit operator decimal(LargeInteger a)
        {
            // Obviously not the most optimal way to go, but I'm not gonna bother unless someone implements those structures more developer-friendly
            try
            {
                decimal result = 0;
                for (int i = a.Bytes.Count - 1; i > General.Max(a.Bytes.Count - 12, 0); i--)
                    result += a.Bytes[i] * (decimal)General.Power(2, i * 8);
                result = result * (a < 0 ? -1 : 1);
                return result;
            }
            catch { throw new OverflowException("The LargeInteger was too big."); } // Really, brackets are not necessary for single-line statements
        }   
        // Add more casts
        #endregion
        #region Operators
        public static LargeInteger operator +(LargeInteger left, LargeInteger right)
        {
            LargeInteger result = new LargeInteger();
            result.Bytes.AddRange(new byte[General.Max(left.Length, right.Length) + 1]); // Add as many bytes as needed for both the integers
            if (!left.Sign && !right.Sign)
                result.Sign = false;
            else if (left.Sign && right.Sign)
                result.Sign = true;
            else if (!left.Sign && right.Sign)
            {
                if (left.Length > right.Length)
                    result.Sign = false;
                else if (left.Length < right.Length)
                    result.Sign = true;
                else if (left.Length == right.Length)
                    for (int i = 0; i < left.Length; i++)
                        if (left.Bytes[i] != right.Bytes[i])
                        {
                            result.Sign = left.Bytes[left.Length - 1] < right.Bytes[right.Length - 1];
                            break;
                        }
            }
            else if (left.Sign && !right.Sign)
            {
                if (left.Length > right.Length)
                    result.Sign = true;
                else if (left.Length < right.Length)
                    result.Sign = false;
                else if (left.Length == right.Length)
                    for (int i = 0; i < left.Length; i++)
                        if (left.Bytes[i] != right.Bytes[i])
                        {
                            result.Sign = left.Bytes[left.Length - 1] > right.Bytes[right.Length - 1];
                            break;
                        }
            }
            for (int i = 0; i < result.Length - 1; i++) // Insert the result per bytes
            {
                int sum = 0;
                if (i < left.Length && i < right.Length) // Add both numbers in the sum if the byte positions are in the bounds of both numbers' byte list
                {
                    if (left.Sign && right.Sign) // If both numbers are positive
                        sum = left.Bytes[i] + right.Bytes[i];
                    else if (!left.Sign && right.Sign) // If the left number is negative and the other is positive
                        sum = right.Bytes[i] - left.Bytes[i];
                    else if (left.Sign && !right.Sign) // If the right number is negative and the other is positive
                        sum = left.Bytes[i] - right.Bytes[i];
                    else if (!left.Sign && !right.Sign) // If both numbers are negative
                        sum = -left.Bytes[i] - right.Bytes[i];
                }
                else if (i < left.Length && i >= right.Length) // Only add the left number in the byte position if the byte index is out of range of the right number's byte list
                    sum = left.Bytes[i] * (left.Sign ? 1 : -1);
                else if (i >= left.Length && i < right.Length) // Only add the right number in the byte position if the byte index is out of range of the left number's byte list
                    sum = right.Bytes[i] * (right.Sign ? 1 : -1);
                if (sum >= 256 - result.Bytes[i]) // If the sum is positive and bigger than the max value of a byte
                {
                    sum -= 256;
                    result.Bytes[i] = (byte)sum;
                    int j = i + 1;
                    do
                    {
                        result.Bytes[j]++;
                        j++;
                    }
                    while (j < result.Length && result.Bytes[j - 1] == 0);
                }
                else if (sum <= -result.Bytes[i]) // If the sum is negative and its absolute value is bigger than the max value of a byte
                {
                    sum += 256;
                    result.Bytes[i] = (byte)sum;
                    result.Bytes[i + 1]++;
                    int j = i + 1;
                    do
                    {
                        result.Bytes[j]--;
                        j++;
                    }
                    while (j < result.Length && result.Bytes[j - 1] == 0);
                }
            }
            return RemoveUnnecessaryBytes(result);
        }
        public static LargeInteger operator -(LargeInteger left, LargeInteger right) => left + (-right);
        public static LargeInteger operator *(LargeInteger left, LargeInteger right)
        {
            if (left == 0 || right == 0)
                return 0;
            else if (left == 1)
                return right;
            else if (right == 1)
                return left;
            else if (left == -1)
                return -right;
            else if (right == -1)
                return -left;
            else
            {
                LargeInteger result = 0;
                result.Sign = left.Sign == right.Sign;
                left = AbsoluteValue(left);
                right = AbsoluteValue(right);

                while (right > 0)
                {
                    LargeInteger temp = (right >> 1) << 1;
                    if (temp != right) result += left;
                    if ((left.Bytes[left.Length - 1] & 0x80) == 1)
                        left.Bytes.Add(0);
                    left <<= 1;
                    right >>= 1;
                }
                return result;
            }
        }
        /*
           Copyright stuff

           Use of this program, for any purpose, is granted the author,
           Ian Kaplan, as long as this copyright notice is included in
           the source code or any source code derived from this program.
           The user assumes all responsibility for using this code.

           Ian Kaplan, October 1996
        */
        // The division and modulus operations are using copyrighted code form the owner as stated in the aforementioned pasted claim by Ian Kaplan
        // This is a transcription in C# from the source as written in C++, however copyright applies for the algorithm expressed as code
        // Ironically enough, the code contained a mistake causing false results that be way off the expected
        // In fact, the error was the following:
        // Original (C++):                   q = !((t & 0x80000000) >> 31);
        // Original (C#):                    q = ~((t & 0x80000000) >> 31);
        // Original (C# - General-purpose):  q = ~((t & (1 << (t.Length * 8 - 1))) >> (t.Length * 8 - 1));
        // Fixed (C# - General-purpose):     q = ~(t & (1 << (t.Length * 8 - 1))) >> (t.Length * 8 - 1);
        // The only results that would be produced from the original in C++ would either be 0xFFFFFFFF or 0x00000000 which is unwanted.
        // That is, only if the compiler takes the parentheses into consideration properly
        public static LargeInteger operator /(LargeInteger left, LargeInteger right)
        {
            if (right != 0)
            {
                LargeInteger absoluteLeft = AbsoluteValue(left);
                LargeInteger absoluteRight = AbsoluteValue(right);
                if (absoluteLeft == absoluteRight)
                    return left.Sign == right.Sign ? 1 : -1;
                else if (absoluteRight == 1)
                    return left * (left.Sign == right.Sign ? 1 : -1);
                else if (absoluteLeft < absoluteRight)
                    return 0;
                else
                {
                    LargeInteger result = 0;
                    result.Sign = left.Sign == right.Sign;
                    LargeInteger numBits = absoluteLeft.Length * 8;
                    LargeInteger t, q, bit, d = 0;
                    LargeInteger remainder = 0;
                    while (remainder < absoluteRight)
                    {
                        bit = (absoluteLeft & (1 << (absoluteLeft.Length * 8 - 1))) >> (absoluteLeft.Length * 8 - 1);
                        remainder = (remainder << 1) | bit;
                        d = absoluteLeft;
                        absoluteLeft <<= 1;
                        numBits--;
                    }

                    /* The loop, above, always goes one iteration too far.
                       To avoid inserting an "if" statement inside the loop
                       the last iteration is simply reversed. */

                    absoluteLeft = d;
                    remainder = remainder >> 1;
                    numBits++;

                    for (LargeInteger i = 0; i < numBits; i++)
                    {
                        bit = (absoluteLeft & (1 << (absoluteLeft.Length * 8 - 1))) >> (absoluteLeft.Length * 8 - 1);
                        remainder = (remainder << 1) | bit;
                        t = remainder - absoluteRight;
                        q = ~(t & (1 << (t.Length * 8 - 1))) >> (t.Length * 8 - 1);
                        absoluteLeft <<= 1;
                        result = (result << 1) | q;
                        if (q != 0)
                            remainder = t;
                    }
                    return result;
                }
            }
            else throw new DivideByZeroException("Cannot divide by zero.");
        }
        public static LargeInteger operator %(LargeInteger left, LargeInteger right)
        {
            if (right != 0)
            {
                LargeInteger absoluteLeft = AbsoluteValue(left);
                LargeInteger absoluteRight = AbsoluteValue(right);
                if (absoluteLeft == absoluteRight || absoluteRight == 1)
                    return 0;
                else if (absoluteLeft < absoluteRight)
                    return left;
                else
                {
                    LargeInteger numBits = left.Length * 8; // numBits = the number of bits of the dividend
                    LargeInteger t, q, bit, d = 0; // t = temporary value, q = quotient, bit = last bit being checked, d = temporary dividend value for reversing previous operation
                    LargeInteger remainder = 0;
                    while (remainder < absoluteRight)
                    {
                        bit = (absoluteLeft & (1 << (absoluteLeft.Length * 8 - 1))) >> (absoluteLeft.Length * 8 - 1);
                        remainder = (remainder << 1) | bit;
                        d = absoluteLeft;
                        absoluteLeft <<= 1;
                        numBits--;
                    }

                    /* The loop, above, always goes one iteration too far.
                        To avoid inserting an "if" statement inside the loop
                        the last iteration is simply reversed. */

                    absoluteLeft = d;
                    remainder = remainder >> 1;
                    numBits++;

                    for (LargeInteger i = 0; i < numBits; i++)
                    {
                        bit = (absoluteLeft & (1 << (absoluteLeft.Length * 8 - 1))) >> (absoluteLeft.Length * 8 - 1);
                        remainder = (remainder << 1) | bit;
                        t = remainder - absoluteRight;
                        q = ~(t & (1 << (t.Length * 8 - 1))) >> (t.Length * 8 - 1);
                        absoluteLeft <<= 1;
                        if (q != 0)
                            remainder = t;
                    }
                    return remainder;
                }
            }
            else throw new DivideByZeroException("Cannot divide by zero.");
        }
        public static LargeInteger operator ++(LargeInteger l) => l + 1;
        public static LargeInteger operator --(LargeInteger l) => l - 1;
        public static LargeInteger operator >>(LargeInteger left, int right)
        {
            if (left != 0)
            {
                LargeInteger result = left;
                int shifts = right % 8;
                int fullShifts = right / 8;
                if (fullShifts > 0)
                {
                    for (int i = 0; i < result.Length - fullShifts; i++)
                        result.Bytes[i] = result.Bytes[i + fullShifts];
                    result.Bytes.RemoveRange(result.Length - fullShifts, fullShifts);
                }
                if (shifts > 0)
                {
                    for (int i = 0; i < result.Length - 1; i++)
                        result.Bytes[i] = (byte)((result.Bytes[i] >> shifts) + (result.Bytes[i + 1] << (8 - shifts)));
                    result.Bytes[result.Length - 1] = (byte)(result.Bytes[result.Length - 1] >> shifts);
                }
                return result;
            }
            else return 0;
        }
        public static LargeInteger operator <<(LargeInteger left, int right)
        {
            if (left != 0)
            {
                LargeInteger result = left;
                int shifts = right % 8;
                int fullShifts = right / 8;
                for (int i = 0; i < fullShifts; i++)
                    result.Bytes.Add(result.Bytes[i - fullShifts]);
                if (fullShifts > 0)
                {
                    for (int i = result.Length - fullShifts; i > fullShifts; i--)
                        result.Bytes[i] = result.Bytes[i - fullShifts];
                    result.Bytes[fullShifts] = 0;
                    fullShifts++;
                }
                if (shifts > 0)
                {
                    for (int i = result.Length - 1; i > fullShifts; i--)
                        result.Bytes[i] = (byte)((result.Bytes[i - 1] << shifts) | (result.Bytes[i] >> (8 - shifts)));
                    result.Bytes[fullShifts] = (byte)(result.Bytes[fullShifts] << shifts);
                }
                return result;
            }
            else return 0;
        }
        public static LargeInteger operator -(LargeInteger l)
        {
            l.Sign = !l.Sign;
            return l;
        }
        public static LargeInteger operator &(LargeInteger left, LargeInteger right)
        {
            int minLength = General.Min(left.Length, right.Length);
            byte[] bytes = new byte[minLength];
            for (int i = 0; i < minLength; i++)
                bytes[i] = (byte)(left.Bytes[i] & right.Bytes[i]);
            LargeInteger result = new LargeInteger(bytes);
            result.Sign = left.Sign & right.Sign;
            return result;
        }
        public static LargeInteger operator |(LargeInteger left, LargeInteger right)
        {
            int minLength = General.Min(left.Length, right.Length);
            int maxLength = General.Max(left.Length, right.Length);
            byte[] bytes = new byte[maxLength];
            for (int i = 0; i < minLength; i++)
                bytes[i] = (byte)(left.Bytes[i] | right.Bytes[i]);
            if (left.Length > right.Length)
                for (int i = minLength; i < maxLength; i++)
                    bytes[i] = left.Bytes[i];
            else
                for (int i = minLength; i < maxLength; i++)
                    bytes[i] = right.Bytes[i];
            LargeInteger result = new LargeInteger(bytes);
            result.Sign = left.Sign | right.Sign;
            return result;
        }
        public static LargeInteger operator ^(LargeInteger left, LargeInteger right)
        {
            int minLength = General.Min(left.Length, right.Length);
            int maxLength = General.Max(left.Length, right.Length);
            byte[] bytes = new byte[maxLength];
            for (int i = 0; i < minLength; i++)
                bytes[i] = (byte)(left.Bytes[i] ^ right.Bytes[i]);
            if (left.Length > right.Length)
                for (int i = minLength; i < maxLength; i++)
                    bytes[i] = left.Bytes[i];
            else
                for (int i = minLength; i < maxLength; i++)
                    bytes[i] = right.Bytes[i];
            LargeInteger result = new LargeInteger(bytes);
            result.Sign = left.Sign ^ right.Sign;
            return result;
        }
        public static LargeInteger operator ~(LargeInteger l)
        {
            for (int i = 0; i < l.Length; i++)
                l.Bytes[i] = (byte)~l.Bytes[i];
            return l;
        }
        public static bool operator >(LargeInteger left, LargeInteger right)
        {
            if (left.Sign && right.Sign)
            {
                if (left.Length > right.Length)
                    return true;
                else if (left.Length < right.Length)
                    return false;
                else
                    for (int i = left.Length - 1; i >= 0; i--)
                        if (left.Bytes[left.Length - 1] > right.Bytes[left.Length - 1])
                            return true;
                return false;
            }
            else if (!left.Sign && !right.Sign)
            {
                if (left.Length < right.Length)
                    return true;
                else if (left.Length > right.Length)
                    return false;
                else
                    for (int i = left.Length - 1; i >= 0; i--)
                        if (left.Bytes[left.Length - 1] < right.Bytes[left.Length - 1])
                            return true;
                return false;
            }
            else return left.Sign;
        }
        public static bool operator <(LargeInteger left, LargeInteger right)
        {
            if (left.Sign && right.Sign)
            {
                if (left.Length < right.Length)
                    return true;
                else if (left.Length > right.Length)
                    return false;
                else
                    for (int i = left.Length - 1; i >= 0; i--)
                        if (left.Bytes[left.Length - 1] < right.Bytes[left.Length - 1])
                            return true;
                return false;
            }
            else if (!left.Sign && !right.Sign)
            {
                if (left.Length > right.Length)
                    return true;
                else if (left.Length < right.Length)
                    return false;
                else
                    for (int i = left.Length - 1; i >= 0; i--)
                        if (left.Bytes[left.Length - 1] > right.Bytes[left.Length - 1])
                            return true;
                return false;
            }
            else return right.Sign;
        }
        public static bool operator >=(LargeInteger left, LargeInteger right) => left > right || left == right;
        public static bool operator <=(LargeInteger left, LargeInteger right) => left < right || left == right;
        public static bool operator ==(LargeInteger left, LargeInteger right)
        {
            if (left.Length != right.Length)
                return false;
            else if (left.Length == right.Length)
                for (int i = 0; i < left.Length; i++)
                    if (left.Bytes[i] != right.Bytes[i])
                        return false;
            return true;
        }
        public static bool operator !=(LargeInteger left, LargeInteger right)
        {
            if (left.Length != right.Length)
                return true;
            else if (left.Length == right.Length)
                for (int i = 0; i < left.Length; i++)
                    if (left.Bytes[i] != right.Bytes[i])
                        return true;
            return false;
        }
        #endregion
        #region Operations
        // Need to write documentation for the functions and their parameters
        /// <summary>Determines whether an instance of <seealso cref="LargeInteger"/> is a prime or not.</summary>
        /// <param name="l">The instance of <seealso cref="LargeInteger"/> to check for being a prime.</param>
        public static bool IsPrime(LargeInteger l)
        {
            bool result = false;
            LargeInteger sqrt = SquareRoot(l);
            for (int i = 2; i <= sqrt; i++)
                if (l % i == 0) break;
                else result = i == sqrt;
            return result;
        }
        /// <summary>Determines whether an instance of <seealso cref="LargeInteger"/> is a Fibonacci number or not.</summary>
        /// <param name="l">The instance of <seealso cref="LargeInteger"/> to check for being a Fibonacci number.</param>
        public static bool IsFibonacci(LargeInteger n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException();
            else if (n == 0 || n == 1) return true;
            else
            {
                List<LargeInteger> fibonacciNumbers = new List<LargeInteger> { 0, 1 };
                for (int i = 2; fibonacciNumbers.Last() <= n; i++)
                    fibonacciNumbers.Add(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]);
                return fibonacciNumbers.Last() == n;
            }
        }
        /// <summary>Parses a <seealso cref="string"/> as an instance of <seealso cref="LargeInteger"/>. Returns <see langword="true"/> if the string is valid <seealso cref="LargeInteger"/>, otherwise <see langword="false"/>.</summary>
        /// <param name="str">The string to parse.</param>
        /// <param name="result">The variable to return the converted instance of <seealso cref="LargeInteger"/> to.</param>
        public static bool TryParse(string str, out LargeInteger result)
        {
            result = 0;
            try { result = Parse(str); }
            catch { return false; }
            return true;
        }
        /// <summary>Returns the relation between two instances of <seealso cref="LargeInteger"/>. The result is the relation based on the left <seealso cref="LargeInteger"/>.</summary>
        /// <param name="a">The left instance of <seealso cref="LargeInteger"/> to compare.</param>
        /// <param name="b">The right instance of <seealso cref="LargeInteger"/> to compare.</param>
        public static Comparison GetRelation(LargeInteger a, LargeInteger b)
        {
            if (a < b)
                return Comparison.LessThan;
            else if (a == b)
                return Comparison.EqualTo;
            else
                return Comparison.GreaterThan;
            // Simple implementation, might need to optimize a bit
        }
        /// <summary>Gets the decimal digit count of an instance of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="l">The instance of <seealso cref="LargeInteger"/> whose decimal digits to get.</param>
        public static int GetDecimalDigitCount(LargeInteger l)
        {
            int digCount = (l.Length - 1) * 2 + 1;
            for (int i = digCount; i < l.Length * 3; i++)
                if (l % Power(10, i) > 0)
                    digCount = i;
            return digCount;
        }
        /// <summary>Returns the absolute value of a <seealso cref="LargeInteger"/>.</summary>
        /// <param name="l">The <seealso cref="LargeInteger"/> whose absolute value to get.</param>
        public static LargeInteger AbsoluteValue(LargeInteger l) => l >= 0 ? l : -l;
        /// <summary>Returns the average of a number of instances of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="a">The array of instances of <seealso cref="LargeInteger"/> to calculate the average of.</param>
        public static LargeInteger Average(params LargeInteger[] l) => Sum(l) / l.Length;
        /// <summary>Returns the factorial of a <seealso cref="LargeInteger"/>.</summary>
        /// <param name="l">The <seealso cref="LargeInteger"/> whose factorial to get.</param>
        public static LargeInteger Factorial(LargeInteger l)
        {
            LargeInteger result = 1;
            for (LargeInteger i = l; i > 1; i--) // It's prefered to do the comparison between the LargeInteger and 1 simply because 1 is converted to a LargeInteger which is compared really fast due to its small length
                result *= i;
            return result;
        }
        /// <summary>Returns the n-th Fibonacci with n being an one-based index with the list starting from 0 (0, 1, 1, 2, 3, 5, ...).</summary>
        /// <param name="n">The one-based index index of the prime to return.</param>
        public static LargeInteger GetNthFibonacci(int n)
        {
            if (n <= 0) throw new ArgumentOutOfRangeException();
            if (n == 1) return 2;
            else
            {
                List<LargeInteger> fibonacciNumbers = new List<LargeInteger> { 0, 1 };
                for (int i = 2; fibonacciNumbers.Count <= n; i++)
                    fibonacciNumbers.Add(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]);
                return fibonacciNumbers.Last();
            }
        }
        /// <summary>Returns the n-th prime with n being an one-based index.</summary>
        /// <param name="n">The one-based index index of the prime to return.</param>
        public static LargeInteger GetNthPrime(int n)
        {
            if (n <= 0) throw new ArgumentOutOfRangeException();
            if (n == 1) return 2;
            else
            {
                List<LargeInteger> primesFound = new List<LargeInteger> { 1, 2 };
                bool isPrime = true;
                for (LargeInteger p = 3; primesFound.Count <= n; p++)
                {
                    for (int i = 0; i < primesFound.Count && isPrime; i++)
                        isPrime = p % primesFound[i] != 0;
                    if (isPrime)
                        primesFound.Add(p);
                }
                return primesFound.Last();
            }
        }
        /// <summary>Returns the greatest common divisor of 2 of instances of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="a">The first instance of <seealso cref="LargeInteger"/>.</param>
        /// <param name="b">The second instance of <seealso cref="LargeInteger"/>.</param>
        public static LargeInteger GreatestCommonDivisor(LargeInteger a, LargeInteger b)
        {
            LargeInteger max = Max(a, b);
            LargeInteger GCD = 1;
            for (LargeInteger i = 1; i < max / 2; i++)
                if (a % i == 0 && b % i == 0)
                    GCD = i;
            return GCD;
        }
        /// <summary>Returns the greatest common divisor of a number of instances of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="l">The array of instances of <seealso cref="LargeInteger"/>.</param>
        public static LargeInteger GreatestCommonDivisor(params LargeInteger[] l)
        {
            LargeInteger max = Max(l);
            LargeInteger GCD = 1;
            bool isDivisible = true;
            for (LargeInteger i = 1; i < max / 2; i++)
            {
                for (int j = 0; j < l.Length && isDivisible; j++)
                    isDivisible = l[j] % i == 0;
                if (isDivisible)
                    GCD = i;
            }
            return GCD;
        }
        /// <summary>Returns the least common multiple of 2 of instances of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="a">The first instance of <seealso cref="LargeInteger"/>.</param>
        /// <param name="b">The second instance of <seealso cref="LargeInteger"/>.</param>
        public static LargeInteger LeastCommonMultiple(LargeInteger a, LargeInteger b) => a * b / GreatestCommonDivisor(a, b);
        // Implement LCM for more than just two instances of LargeInteger
        public static LargeInteger Max(params LargeInteger[] n)
        {
            LargeInteger max = n[0];
            for (int i = 1; i < n.Length; i++)
                if (max < n[i])
                    max = n[i];
            return max;
        }
        public static LargeInteger Min(params LargeInteger[] n)
        {
            LargeInteger min = n[0];
            for (int i = 1; i < n.Length; i++)
                if (min > n[i])
                    min = n[i];
            return min;
        }
        public static LargeInteger Parse(string str)
        {
            LargeInteger result = 0;
            if (str[0] == '-') // If it's the negative sign symbol
            {
                str = str.Remove(0, 1);
                result.Sign = false;
            }
            if (str.Length > 0)
            {
                for (int i = 0; i < str.Length; i++)
                    if (str[i] < '0' || str[i] > '9') // If it's not a number character
                        throw new FormatException("The string is not a valid integral value.");
                for (int i = str.Length - 1; i >= 0; i--)
                    result += str[i] * Power(10, i - str.Length + 1);
            }
            else throw new FormatException("The string represents no integral value.");
            return result;
        }
        public static LargeInteger Power(LargeInteger b, LargeInteger power)
        {
            if (power.Sign)
            {
                LargeInteger brainPower = AbsoluteValue(power);
                LargeInteger result = b;
                for (LargeInteger i = 2; i <= brainPower; i++)
                    result *= b;
                return result;
            }
            else if (!power.Sign)
                return 0;
            else if (b != 0) return 1;
            else throw new ElevateZeroToThePowerOfZeroException();
        }
        public static LargeInteger Random(int length)
        {
            LargeInteger result = new LargeInteger();
            Random shit = new Random();
            result.Bytes = new List<byte>(length);
            for (int i = 0; i < length - 1; i++)
                result.Bytes[i] = (byte)shit.Next(0, 255);
            result.Bytes[length - 1] = (byte)shit.Next(1, 255);
            return result;
        }
        public static LargeInteger Random(int minLength, int maxLength)
        {
            LargeInteger result = new LargeInteger();
            Random shit = new Random();
            int length = shit.Next(minLength, maxLength);
            result.Bytes = new List<byte>(length);
            for (int i = 0; i < length - 1; i++)
                result.Bytes[i] = (byte)shit.Next(0, 255);
            result.Bytes[length - 1] = (byte)shit.Next(1, 255);
            return result;
        }
        public static LargeInteger Random(LargeInteger min, LargeInteger max)
        {
            if (min != max)
            {
                LargeInteger result = new LargeInteger();
                min = RemoveUnnecessaryBytes(min); // Clean the useless zeroes
                max = RemoveUnnecessaryBytes(max);
                Random shit = new Random();
                bool matchesMin = false;
                bool matchesMax = false;
                int length = shit.Next(min.Length, max.Length);
                result.Bytes = new List<byte>(length);
                if (length == min.Length)
                {
                    result.Bytes[length - 1] = (byte)shit.Next(min.Bytes[length - 1], 255);
                    matchesMin = result.Bytes[length - 1] == min.Bytes[length - 1];
                }
                else if (length == max.Length)
                {
                    result.Bytes[length - 1] = (byte)shit.Next(1, max.Bytes[length - 1]);
                    matchesMax = result.Bytes[length - 1] == max.Bytes[length - 1];
                }
                for (int i = length - 2; i >= 0; i--)
                {
                    if (matchesMin)
                    {
                        result.Bytes[i] = (byte)shit.Next(min.Bytes[i], 255);
                        matchesMin = result.Bytes[i] == min.Bytes[i];
                    }
                    else if (matchesMax)
                    {
                        result.Bytes[i] = (byte)shit.Next(min.Bytes[i], 255);
                        matchesMin = result.Bytes[i] == min.Bytes[i];
                    }
                    else
                        result.Bytes[i] = (byte)shit.Next(0, 255);
                }
                return result;
            }
            else return min;
        }
        private static LargeInteger RemoveUnnecessaryBytes(LargeInteger l)
        {
            int i = l.Length - 1;
            while (l.Bytes[i] == 0)
                i--;
            l.Bytes.RemoveRange(i, l.Length - 1 - i);
            return l;
        }
        /// <summary>Returns the square root of any number rounded to the closest integer. Since this is an approximation for decimal integers, it's suggested that this function is only used for integers whose n-th root is an integer.</summary>
        /// <param name="b">The integer to find the root of.</param>
        /// <param name="rootClass">The class of the root.</param>
        public static LargeInteger Root(LargeInteger b, LargeInteger rootClass)
        {
            bool negative = b < 0;
            b.Sign = true; // Already checked if it's a negative number, needless to work around with the stupid negative sign
            if (b == 0 || b == 1) return b;
            else if (rootClass % 2 == 0 && negative) throw new Exception(); // EvenClassRootOfNegativeNumberException
            else if (b > 1)
            {
                int digCount = GetDecimalDigitCount(b);
                int maxRootCount = digCount / 2 + 1;
                int minRootCount = General.Max((digCount / 2 - 1), 1);
                LargeInteger start = Power(10, (minRootCount - 1));
                LargeInteger end = Power(10, maxRootCount) - 1;
                LargeInteger middle = (start + end) / 2;
                LargeInteger power;
                while ((power = Power(middle, rootClass)) != b && start <= end)
                {
                    if (power < b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                middle.Sign = !negative;
                return middle;
            }
            else // if (0 < b < 1)
            {
                int digCount = GetDecimalDigitCount(b);
                int maxRootCount = digCount / 2 + 1;
                int minRootCount = General.Max((digCount / 2 - 1), 1);
                LargeInteger start = Power(10, (minRootCount - 1));
                LargeInteger end = Power(10, maxRootCount) - 1;
                LargeInteger middle = (start + end) / 2;
                LargeInteger power;
                while ((power = Power(middle, rootClass)) != b && start <= end)
                {
                    if (power > b)
                        start = (end + middle) / 2;
                    else
                        end = (start + middle) / 2;
                    middle = (start + end) / 2;
                }
                middle.Sign = !negative;
                return middle;
            }
        }
        /// <summary>Returns the sum of a number of instances of <seealso cref="LargeInteger"/>.</summary>
        /// <param name="a">The array of instances of <seealso cref="LargeInteger"/> to calculate the sum of.</param>
        public static LargeInteger Sum(params LargeInteger[] a)
        {
            LargeInteger result = 0;
            for (int i = 0; i < a.Length; i++)
                result += a[i];
            return result;
        }
        /// <summary>Returns the square root of any number rounded to the closest integer. Since this is an approximation for decimal integers, it's suggested that this function is only used for perfect squares.</summary>
        /// <param name="b">The integer to find the square root of.</param>
        public static LargeInteger SquareRoot(LargeInteger b) => Root(b, 2);
        #endregion
        #region Overrides
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (Sign == false) result.Append("-");
            LargeInteger currentIntPart = this;
            for (LargeInteger i = 1; (currentIntPart = this / i) > 0; i *= 10)
                result.Insert(0, (char)((currentIntPart % 10) + 48));
            return result.ToString();
        }
        #endregion
    }
}