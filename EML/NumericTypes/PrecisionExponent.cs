using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using System.Diagnostics;
using System.Security.Permissions;
using System.Security;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Globalization;
using System.Diagnostics.Contracts;

namespace EML
{
    /// <summary>Represents a number stored with precision multiplied by 10 powered to an exponent.</summary>
    public struct PrecisionExponent
    {
        public decimal Value { get; set; }
        public LargeInteger Exponent { get; set; }

        #region Constructors
        /// <summary>Create a new instance of the <see cref="PrecisionExponent"/> struct.</summary>
        /// <param name="value">The value to parse to the <see cref="PrecisionExponent"/>.</param>
        public PrecisionExponent(decimal value)
        {
            if (value != 0)
            {
                GetPrecisionExponentInfo(value, 0, out var v, out var e);
                Value = v;
                Exponent = e;
            }
            else { Value = 0; Exponent = 1; }
        }
        /// <summary>Create a new instance of the <see cref="PrecisionExponent"/> struct.</summary>
        /// <param name="value">The value to parse to the <see cref="PrecisionExponent"/>.</param>
        /// <param name="exponent">The exponent of the value to parse to the <see cref="PrecisionExponent"/>.</param>
        public PrecisionExponent(decimal value, LargeInteger exponent)
        {
            if (value != 0)
            {
                GetPrecisionExponentInfo(value, exponent, out var v, out var e);
                Value = v;
                Exponent = e;
            }
            else { Value = 0; Exponent = 1; }
        }
        #endregion

        #region Valid PrecisionExponent Conversion Functions
        /// <summary>Sets the parsed values as they are supposed to be in the <see cref="PrecisionExponent"/> struct and returns them.</summary>
        /// <param name="inputValue">The value that will be processed in the <see cref="PrecisionExponent"/>.</param>
        /// <param name="inputExponent">The exponent that will be processed in the <see cref="PrecisionExponent"/>.</param>
        /// <param name="value">The output value as changed in the <see cref="PrecisionExponent"/>.</param>
        /// <param name="exponent">The output exponent as changed in the <see cref="PrecisionExponent"/>.</param>
        static void GetPrecisionExponentInfo(decimal inputValue, LargeInteger inputExponent, out decimal value, out LargeInteger exponent)
        {
            value = inputValue;
            exponent = inputExponent;
            if (General.AbsoluteValue(value) >= 10)
                while (General.AbsoluteValue(value) >= 10)
                {
                    value /= 10;
                    exponent++;
                }
            else if (General.AbsoluteValue(value) < 1)
                while (General.AbsoluteValue(value) < 1)
                {
                    value *= 10;
                    exponent--;
                }
        }
        /// <summary>Returns a new <see cref="PrecisionExponent"/> object with the proper values.</summary>
        /// <param name="input">The <see cref="PrecisionExponent"/> to get the info from.</param>
        static PrecisionExponent GetPrecisionExponentInfo(PrecisionExponent input)
        {
            PrecisionExponent output = input;
            if (General.AbsoluteValue(output.Value) >= 10)
                while (General.AbsoluteValue(output.Value) >= 10)
                {
                    output.Value /= 10;
                    output.Exponent++;
                }
            else if (General.AbsoluteValue(output.Value) < 1)
                while (General.AbsoluteValue(output.Value) < 1)
                {
                    output.Value *= 10;
                    output.Exponent--;
                }
            return output;
        }
        #endregion

        #region Operators
        /// <summary>Adds the values of the two <see cref="PrecisionExponent"/> objects and returns their sum.</summary>
        public static PrecisionExponent operator +(PrecisionExponent left, PrecisionExponent right)
        {
            LargeInteger times = right.Exponent - left.Exponent;
            for (LargeInteger i = 1; i < times; i++)
                right.Value /= 10;
            return new PrecisionExponent(left.Value + right.Value, left.Exponent);
        }
        /// <summary>Subtracts the value of the second <see cref="PrecisionExponent"/> object from the value of the first <see cref="PrecisionExponent"/> object and returns their difference.</summary>
        public static PrecisionExponent operator -(PrecisionExponent left, PrecisionExponent right)
        {
            LargeInteger times = right.Exponent - left.Exponent;
            for (LargeInteger i = 1; i < times; i++)
                right.Value /= 10;
            return new PrecisionExponent(left.Value - right.Value, left.Exponent);
        }
        /// <summary>Multiplies the value of the first <see cref="PrecisionExponent"/> object with the value of the second <see cref="PrecisionExponent"/> object and returns the product.</summary>
        public static PrecisionExponent operator *(PrecisionExponent left, PrecisionExponent right) => new PrecisionExponent(left.Value * right.Value, left.Exponent + right.Exponent);
        /// <summary>Divides the value of the first <see cref="PrecisionExponent"/>object by the value of the second <see cref="PrecisionExponent"/> object and returns the result.</summary>
        public static PrecisionExponent operator /(PrecisionExponent left, PrecisionExponent right)
        {
            if (right.Value != 0) return new PrecisionExponent(left.Value / right.Value, left.Exponent - right.Exponent);
            else throw new DivideByZeroException("Cannot divide by zero.");
        }
        /// <summary>Adds one to the <see cref="PrecisionExponent"/>.</summary>
        public static PrecisionExponent operator ++(PrecisionExponent p) => p + One;
        /// <summary>Subtracts one from the <see cref="PrecisionExponent"/>.</summary>
        public static PrecisionExponent operator --(PrecisionExponent p) => p - One;
        /// <summary>Returns whether the value of the first <see cref="PrecisionExponent"/> object is greater than the value of the second <see cref="PrecisionExponent"/> object.</summary>
        public static bool operator >(PrecisionExponent left, PrecisionExponent right)
        {
            if (left.Exponent == right.Exponent)
                return left.Value > right.Value;
            else
            {
                if (HaveSameSign(left, right))
                    return left.Exponent > right.Exponent;
                else
                    return left.Value > 0;
            }
        }
        /// <summary>Returns whether the value of the first <see cref="PrecisionExponent"/> object is smaller than the value of the second <see cref="PrecisionExponent"/> object.</summary>
        public static bool operator <(PrecisionExponent left, PrecisionExponent right)
        {
            if (left.Exponent == right.Exponent)
                return left.Value < right.Value;
            else
            {
                if (HaveSameSign(left, right))
                    return left.Exponent < right.Exponent;
                else
                    return left.Value < 0;
            }
        }
        /// <summary>Returns whether the value of the first <see cref="PrecisionExponent"/> object is greater than or equal to the value of the second <see cref="PrecisionExponent"/> object.</summary>
        public static bool operator >=(PrecisionExponent left, PrecisionExponent right)
        {
            if (left.Exponent == right.Exponent)
                return left.Value >= right.Value;
            else
            {
                if (HaveSameSign(left, right))
                    return left.Exponent >= right.Exponent;
                else
                    return left.Value >= 0;
            }
        }
        /// <summary>Returns whether the value of the first <see cref="PrecisionExponent"/> object is smaller than or equal to the value of the second <see cref="PrecisionExponent"/> object.</summary>
        public static bool operator <=(PrecisionExponent left, PrecisionExponent right)
        {
            if (left.Exponent == right.Exponent)
                return left.Value <= right.Value;
            else
            {
                if (HaveSameSign(left, right))
                    return left.Exponent <= right.Exponent;
                else
                    return left.Value <= 0;
            }
        }
        /// <summary>Returns whether the value of the first <see cref="PrecisionExponent"/> object is equal to the value of the second <see cref="PrecisionExponent"/> object.</summary>
        public static bool operator ==(PrecisionExponent left, PrecisionExponent right) => left.Exponent == right.Exponent && left.Value == right.Value;
        /// <summary>Returns whether the value of the first <see cref="PrecisionExponent"/> object is not equal to the value of the second <see cref="PrecisionExponent"/> object.</summary>
        public static bool operator !=(PrecisionExponent left, PrecisionExponent right) => left.Exponent != right.Exponent && left.Value != right.Value;
        #endregion

        #region Implicit Conversions
        public static implicit operator PrecisionExponent(byte b) => new PrecisionExponent(b);
        public static implicit operator PrecisionExponent(sbyte sb) => new PrecisionExponent(sb);
        public static implicit operator PrecisionExponent(ushort us) => new PrecisionExponent(us);
        public static implicit operator PrecisionExponent(short s) => new PrecisionExponent(s);
        public static implicit operator PrecisionExponent(uint ui) => new PrecisionExponent(ui);
        public static implicit operator PrecisionExponent(int i) => new PrecisionExponent(i);
        public static implicit operator PrecisionExponent(ulong ul) => new PrecisionExponent(ul);
        public static implicit operator PrecisionExponent(long l) => new PrecisionExponent(l);
        public static implicit operator PrecisionExponent(decimal d) => new PrecisionExponent(d);
        public static implicit operator PrecisionExponent(double d) => new PrecisionExponent((decimal)d);
        public static implicit operator PrecisionExponent(float f) => new PrecisionExponent((decimal)f);
        #endregion

        #region Operations
        /// <summary>Returns the result of the power of a number.</summary>
        /// <param name="p">The <see cref="PrecisionExponent"/> to elevate to a power.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static PrecisionExponent Power(PrecisionExponent p, double power)
        {
            if (p.Value == 0 && power == 0) throw new ElevateZeroToThePowerOfZeroException("Cannot elevate zero to the power of zero.");
            else if (power == 1) return p;
            else if (p == 1) return 1;
            else
            {
                PrecisionExponent result = p;
                result.Value = (decimal)doublePow((double)result.Value, power);
                result.Value *= (decimal)doublePow(10, power - (int)power);
                result.Exponent *= (int)power;
                return GetPrecisionExponentInfo(result);
            }
        }
        /// <summary>Returns the result of the power of a number.</summary>
        /// <param name="p">The <see cref="PrecisionExponent"/> to elevate to a power.</param>
        /// <param name="power">The power to elevate the number to.</param>
        public static PrecisionExponent Power(PrecisionExponent p, PrecisionExponent power)
        {
            if (p.Value == 0 && power.Value == 0) throw new ElevateZeroToThePowerOfZeroException("Cannot elevate zero to the power of zero.");
            else if (power == 1) return p;
            else if (p == 1) return 1;
            else
            {
                LargeInteger doubleMaxExponentCount = LargeInteger.AbsoluteValue(p.Exponent) / 308;
                int lastExponent = (int)(LargeInteger.AbsoluteValue(p.Exponent) % 308);
                PrecisionExponent result = p;
                for (LargeInteger i = 0; i < doubleMaxExponentCount; i++)
                    result = Power(result, 308);
                result = Power(result, lastExponent);
                return GetPrecisionExponentInfo(result);
            }
        }
        /// <summary>Reverses the number that is specified.</summary>
        /// <param name="p">The <see cref="PrecisionExponent"/> to reverse.</param>
        public static PrecisionExponent Reverse(PrecisionExponent p) => One / p;
        /// <summary>Returns one or greater from the value that is specified.</summary>
        /// <param name="p">The <see cref="PrecisionExponent"/> to examine.</param>
        public static PrecisionExponent OneOrGreater(PrecisionExponent p) => (p = GetPrecisionExponentInfo(p)).Exponent >= 0 ? p : One;
        ///// <summary>Returns the result of the arrows hyperoperation.</summary>
        ///// <param name="a">The base number which is also going to be used as the exponent.</param>
        ///// <param name="n">The number of arrows. Must be a non-negative number.</param>
        ///// <param name="b">The stack of operations. Must be a non-negative number.</param>
        //public static PrecisionExponent Arrow(int a, PrecisionExponent n, int b)
        //{
        //    if (n < 0) throw new ArgumentException("The number of arrows cannot be a negative number.", "n");
        //    else if (b < 0) throw new ArgumentException("The stack cannot be a negative number.", "b");
        //    else if (a == 0) throw new ElevateZeroToThePowerOfZeroException("Cannot elevate zero to the power of zero.");
        //    else if (n == 0) return a * b;
        //    else if (n >= 1 && b == 0) return 1;
        //    else if (n == 1) return doublePow(a, b);
        //    else
        //    {
        //        PrecisionExponent result = a;
        //        for (int i = 1; i < b; i++)
        //        {
        //            // What the fuck can you do to avoid StackOverflowException?!
        //        }
        //        return result;
        //    }
        //}
        /// <summary>Returns the absolute value of the <see cref="PrecisionExponent"/>.</summary>
        /// <param name="p">The <see cref="PrecisionExponent"/> to get the absolute value of.</param>
        public static PrecisionExponent Abs(PrecisionExponent p) => (p.Value < 0) ? p * -1 : p;
        /// <summary>Returns the result of a power tower consisting of n copies of a.</summary>
        /// <param name="a">The base value that will be used in the power tower.</param>
        /// <param name="n">The number of copies to return.</param>
        /// <returns></returns>
        public static PrecisionExponent PowerTower(int a, int n)
        {
            if (a <= 0) throw new ArgumentException("The base cannot be a negative number or zero.", "a");
            else if (n < 0) throw new ArgumentException("The number of copies cannot be a negative number.", "n");
            else if (n == 0) return 1;
            PrecisionExponent result = a;
            for (int i = 1; i < n; i++)
                result = Power(a, result);
            return result;
        }
        /// <summary>Determines whether the two <see cref="PrecisionExponent"/> objects' values have the same sign.</summary>
        /// <param name="a">The first <see cref="PrecisionExponent"/> to examine.</param>
        /// <param name="b">The second <see cref="PrecisionExponent"/> to examine.</param>
        public static bool HaveSameSign(PrecisionExponent a, PrecisionExponent b) => (a.Value < 0 && b.Value < 0) || (a.Value > 0 && b.Value > 0);
        #endregion

        #region Overrdides
        public override string ToString() => Value.ToString() + " * 10 ^ " + Exponent.ToString();
        #endregion

        #region Constant Fields
        /// <summary>Represents a <see cref="PrecisionExponent"/> with the value of zero.</summary>
        public static PrecisionExponent Zero { get { return new PrecisionExponent(0); } }
        /// <summary>Represents a <see cref="PrecisionExponent"/> with the value of one.</summary>
        public static PrecisionExponent One { get { return new PrecisionExponent(1); } }
        #endregion
    }
}