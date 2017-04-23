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
    public class ExtendedMath
    {
        /// <summary>An unlimited integer that is stored as plain text.</summary>
        public struct BigIntS
        {
            string Value
            {
                get { return Value; }
                set { ParseString(value); }
            }
            #region Constructors
            public BigIntS(object value)
            {
                for (int i = 0; i < value.ToString().Length; i++)
                    if (int.TryParse(value.ToString(), out int dump) == false)
                        throw new ArgumentException("The object is not a valid integer.");
                Value = value.ToString();
            }
            public BigIntS(string value)
            {
                if (int.TryParse(value.ToString(), out int dump) == true)
                    Value = value.ToString();
                else
                    throw new ArgumentException("The string is not a valid integer.");
            }
            public BigIntS(char value)
            {
                if (int.TryParse(value.ToString(), out int dump) == true)
                    Value = value.ToString();
                else
                    throw new ArgumentException("The character is not a valid integer.");
            }
            public BigIntS(bool value)
            {
                Value = Convert.ToInt32(value).ToString();
            }
            public BigIntS(decimal value)
            {
                Value = ((int)value).ToString();
            }
            public BigIntS(double value)
            {
                Value = ((int)value).ToString();
            }
            public BigIntS(float value)
            {
                Value = ((int)value).ToString();
            }
            public BigIntS(long value)
            {
                Value = value.ToString();
            }
            public BigIntS(int value)
            {
                Value = value.ToString();
            }
            public BigIntS(short value)
            {
                Value = value.ToString();
            }
            public BigIntS(byte value)
            {
                Value = value.ToString();
            }
            public BigIntS(ulong value)
            {
                Value = value.ToString();
            }
            public BigIntS(uint value)
            {
                Value = value.ToString();
            }
            public BigIntS(ushort value)
            {
                Value = value.ToString();
            }
            public BigIntS(sbyte value)
            {
                Value = value.ToString();
            }
            #endregion

            public static BigIntS ParseString(string newValue)
            {
                for (int i = 0; i < newValue.Length; i++)
                    if (int.TryParse(newValue[i].ToString(), out int dump) == false)
                        throw new ArgumentException("The value of the new integer contains invalid characters.");
                return new BigIntS(newValue);
            }
            public static BigIntS operator +(BigIntS left, BigIntS right)
            {
                BigIntS result = new BigIntS(0);
                bool over10 = false;
                for (int i = 0; i < Math.Min(left.Value.Length, right.Value.Length); i++)
                {
                    string oResult = (Convert.ToInt32(left.Value[i]) + Convert.ToInt32(left.Value[i])).ToString()[(Convert.ToInt32(left.Value[i]) + Convert.ToInt32(left.Value[i])).ToString().Length - 1].ToString();
                    result.Value = result.Value.Insert(0, (oResult[oResult.Length - 1] + Convert.ToInt32(over10)).ToString());
                    over10 = Convert.ToInt32(oResult) >= 10;
                }
                return result;
            }
        }
        /// <summary>An unlimited decimal that is stored as plain text.</summary>
        public struct BigDecimalS
        {
            string Value
            {
                get { return Value; }
                set { ParseString(value); }
            }
            #region Constructors
            public BigDecimalS(object value)
            {
                for (int i = 0; i < value.ToString().Length; i++)
                    if (decimal.TryParse(value.ToString(), out decimal dump) == false)
                        throw new ArgumentException("The object is not a valid decimal.");
                Value = value.ToString();
            }
            public BigDecimalS(string value)
            {
                if (decimal.TryParse(value.ToString(), out decimal dump) == true)
                    Value = value.ToString();
                else
                    throw new ArgumentException("The string is not a valid decimal.");
            }
            public BigDecimalS(char value)
            {
                if (decimal.TryParse(value.ToString(), out decimal dump) == true)
                    Value = value.ToString();
                else
                    throw new ArgumentException("The character is not a valid decimal.");
            }
            public BigDecimalS(bool value)
            {
                Value = Convert.ToInt32(value).ToString();
            }
            public BigDecimalS(decimal value)
            {
                Value = value.ToString();
            }
            public BigDecimalS(double value)
            {
                Value = value.ToString();
            }
            public BigDecimalS(float value)
            {
                Value = value.ToString();
            }
            public BigDecimalS(long value)
            {
                Value = value.ToString();
            }
            public BigDecimalS(int value)
            {
                Value = value.ToString();
            }
            public BigDecimalS(short value)
            {
                Value = value.ToString();
            }
            public BigDecimalS(byte value)
            {
                Value = value.ToString();
            }
            public BigDecimalS(ulong value)
            {
                Value = value.ToString();
            }
            public BigDecimalS(uint value)
            {
                Value = value.ToString();
            }
            public BigDecimalS(ushort value)
            {
                Value = value.ToString();
            }
            public BigDecimalS(sbyte value)
            {
                Value = value.ToString();
            }
            #endregion

            public static BigDecimalS ParseString(string newValue)
            {
                for (int i = 0; i < newValue.Length; i++)
                    if (decimal.TryParse(newValue[i].ToString(), out decimal dump) == false)
                        throw new ArgumentException("The value of the new decimal contains invalid characters.");
                return new BigDecimalS(newValue);
            }
            public static BigDecimalS operator +(BigDecimalS left, BigDecimalS right)
            {
                BigDecimalS result = new BigDecimalS(0);
                bool over10 = false;
                for (int i = 0; i < Math.Min(left.Value.Length, right.Value.Length); i++)
                {
                    string oResult = (Convert.ToInt32(left.Value[i]) + Convert.ToInt32(left.Value[i])).ToString()[(Convert.ToInt32(left.Value[i]) + Convert.ToInt32(left.Value[i])).ToString().Length - 1].ToString();
                    result.Value = result.Value.Insert(0, (oResult[oResult.Length - 1] + Convert.ToInt32(over10)).ToString());
                    over10 = Convert.ToInt32(oResult) >= 10;
                }
                return result;
            }
        }
        /// <summary>A number represented as an exponent.</summary>
        public struct PrecisionExponent
        {
            decimal Value { get; set; }
            BigInteger Exponent { get; set; }

            #region Constructors
            /// <summary>Create a new instance of the <see cref="PrecisionExponent"/> struct.</summary>
            /// <param name="value">The value to parse to the <see cref="PrecisionExponent"/>.</param>
            public PrecisionExponent(decimal value)
            {
                GetPrecisionExponentInfo(value, 0, out var v, out var e);
                Value = v;
                Exponent = e;
            }
            /// <summary>Create a new instance of the <see cref="PrecisionExponent"/> struct.</summary>
            /// <param name="value">The value to parse to the <see cref="PrecisionExponent"/>.</param>
            /// <param name="exponent">The exponent of the value to parse to the <see cref="PrecisionExponent"/>.</param>
            public PrecisionExponent(decimal value, BigInteger exponent)
            {
                GetPrecisionExponentInfo(value, exponent, out var v, out var e);
                Value = v;
                Exponent = e;
            }
            #endregion

            #region Valid PrecisionExponent Conversion Functions
            /// <summary>Sets the parsed values as they are supposed to be in the <see cref="PrecisionExponent"/> struct and returns them.</summary>
            /// <param name="inputValue">The value that will be processed in the <see cref="PrecisionExponent"/>.</param>
            /// <param name="inputExponent">The exponent that will be processed in the <see cref="PrecisionExponent"/>.</param>
            /// <param name="value">The output value as changed in the <see cref="PrecisionExponent"/>.</param>
            /// <param name="exponent">The output exponent as changed in the <see cref="PrecisionExponent"/>.</param>
            static void GetPrecisionExponentInfo(decimal inputValue, BigInteger inputExponent, out decimal value, out BigInteger exponent)
            {
                value = inputValue;
                exponent = inputExponent;
                if (Math.Abs(value) >= 10)
                    while (Math.Abs(value) >= 10)
                    {
                        value /= 10;
                        exponent++;
                    }
                else if (Math.Abs(value) < 1)
                    while (Math.Abs(value) < 1)
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
                if (Math.Abs(output.Value) >= 10)
                    while (Math.Abs(output.Value) >= 10)
                    {
                        output.Value /= 10;
                        output.Exponent++;
                    }
                else if (Math.Abs(output.Value) < 1)
                    while (Math.Abs(output.Value) < 1)
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
                BigInteger times = right.Exponent - left.Exponent;
                for (BigInteger i = 1; i < times; i++)
                    right.Value /= 10;
                return new PrecisionExponent(left.Value + right.Value, left.Exponent);
            }
            /// <summary>Subtracts the value of the second <see cref="PrecisionExponent"/> object from the value of the first <see cref="PrecisionExponent"/> object and returns their difference.</summary>
            public static PrecisionExponent operator -(PrecisionExponent left, PrecisionExponent right)
            {
                BigInteger times = right.Exponent - left.Exponent;
                for (BigInteger i = 1; i < times; i++)
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
                return left.Exponent >= right.Exponent;
            }
            /// <summary>Returns whether the value of the first <see cref="PrecisionExponent"/> object is smaller than or equal to the value of the second <see cref="PrecisionExponent"/> object.</summary>
            public static bool operator <=(PrecisionExponent left, PrecisionExponent right)
            {
                if (left.Exponent == right.Exponent)
                    return left.Value <= right.Value;
                return left.Exponent <= right.Exponent;
            }
            /// <summary>Returns whether the value of the first <see cref="PrecisionExponent"/> object is equal to the value of the second <see cref="PrecisionExponent"/> object.</summary>
            public static bool operator ==(PrecisionExponent left, PrecisionExponent right)
            {
                return left.Exponent == right.Exponent && left.Value == right.Value;
            }
            /// <summary>Returns whether the value of the first <see cref="PrecisionExponent"/> object is not equal to the value of the second <see cref="PrecisionExponent"/> object.</summary>
            public static bool operator !=(PrecisionExponent left, PrecisionExponent right)
            {
                return left.Exponent != right.Exponent && left.Value != right.Value;
            }
            #endregion

            #region Implicit Convertions
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
            public static implicit operator PrecisionExponent(string s) => new PrecisionExponent(decimal.Parse(s));
            #endregion

            #region Operations
            /// <summary>Returns the result of the power of a number.</summary>
            /// <param name="p">The <see cref="PrecisionExponent"/> to elevate to a power.</param>
            /// <param name="power">The power to elevate the number to.</param>
            public static PrecisionExponent Power(PrecisionExponent p, double power)
            {
                PrecisionExponent result = p;
                result.Value = (decimal)Math.Pow((double)result.Value, power);
                result.Value *= (decimal)Math.Pow(10, power - (int)power);
                result.Exponent *= (int)power;
                return GetPrecisionExponentInfo(result);
            }
            /// <summary>Returns the result of the power of a number.</summary>
            /// <param name="p">The <see cref="PrecisionExponent"/> to elevate to a power.</param>
            /// <param name="power">The power to elevate the number to.</param>
            public static PrecisionExponent Power(PrecisionExponent p, PrecisionExponent power)
            {
                BigInteger doubleMaxExponentCount = BigInteger.Abs(p.Exponent) / 308;
                int lastExponent = (int)(BigInteger.Abs(p.Exponent) % 308);
                PrecisionExponent result = p;
                for (BigInteger i = 0; i < doubleMaxExponentCount; i++)
                    result = Power(result, 308);
                result = Power(result, lastExponent);
                return GetPrecisionExponentInfo(result);
            }
            /// <summary>Reverses the number that is specified.</summary>
            /// <param name="p">The <see cref="PrecisionExponent"/> to reverse.</param>
            public static PrecisionExponent Reverse(PrecisionExponent p) => One / p;
            /// <summary>Returns one or greater from the value that is specified.</summary>
            /// <param name="p">The <see cref="PrecisionExponent"/> to examine.</param>
            public static PrecisionExponent OneOrGreater(PrecisionExponent p) => (p = GetPrecisionExponentInfo(p)).Exponent >= 0 ? p : One;
            /// <summary>Returns the result of the arrows hyperoperation.</summary>
            /// <param name="a">The base number which is also going to be used as the exponent.</param>
            /// <param name="n">The number of arrows. Must be a non-negative number.</param>
            /// <param name="b">The stack of operations. Must be a non-negative number.</param>
            public static PrecisionExponent Arrow(int a, PrecisionExponent n, int b)
            {
                if (n < 0) throw new ArgumentException("The number of arrows cannot be a negative number.", "n");
                else if (b < 0) throw new ArgumentException("The stack cannot be a negative number.", "b");
                else if (a == 0) throw new ElevateZeroToThePowerOfZeroException("Cannot elevate zero to the power of zero.");
                else if (n == 0) return a * b;
                else if (n >= 1 && b == 0) return 1;
                else if (n == 1) return Math.Pow(a, b);
                else
                {
                    PrecisionExponent result = a;
                    for (int i = 1; i < b; i++)
                    {
                        // What the fuck can you do to avoid StackOverflowException?!
                    }
                    return result;
                }
            }
            /// <summary>Returns the absolute value of the <see cref="PrecisionExponent"/>.</summary>
            /// <param name="p">The <see cref="PrecisionExponent"/> to get the absolute value of.</param>
            public static PrecisionExponent Abs(PrecisionExponent p) => (p.Value < 0) ? p * -1 : p;
            /// <summary>Determines whether the two <see cref="PrecisionExponent"/> objects' values have the same sign.</summary>
            /// <param name="a">The first <see cref="PrecisionExponent"/> to examine.</param>
            /// <param name="b">The second <see cref="PrecisionExponent"/> to examine.</param>
            public static bool HaveSameSign(PrecisionExponent a, PrecisionExponent b) => (a.Value < 0 && b.Value < 0) || (a.Value > 0 && b.Value > 0);
            #endregion

            #region Constant Fields
            /// <summary>Represents a <see cref="PrecisionExponent"/> with the value of zero.</summary>
            public static PrecisionExponent Zero { get { return new PrecisionExponent(0); } }
            /// <summary>Represents a <see cref="PrecisionExponent"/> with the value of one.</summary>
            public static PrecisionExponent One { get { return new PrecisionExponent(1); } }
            #endregion
        }
        /// <summary>The exception that is thrown when trying to elevate zero to the power of zero.</summary>
        [ComVisible(true)]
        [Serializable]
        public class ElevateZeroToThePowerOfZeroException : ArithmeticException
        {
            /// <summary>Initializes a new instance of the <see cref="ElevateZeroToThePowerOfZeroException"/> class.</summary>
            public ElevateZeroToThePowerOfZeroException() : base() { }
            /// <summary>Initializes a new instance of the <see cref="ElevateZeroToThePowerOfZeroException"/> class with a specified error message.</summary>
            /// <param name="message">A string that describes the error.</param>
            public ElevateZeroToThePowerOfZeroException(String message) : base(message) { }
            /// <summary>Initializes a new instance of the <see cref="ElevateZeroToThePowerOfZeroException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
            /// <param name="message">The error message that explains the reason for the exception.</param>
            /// <param name="innerException">The exception that is the cause of the current exception. If the innerException parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
            public ElevateZeroToThePowerOfZeroException(String message, Exception innerException) : base(message, innerException) { }
        }
    }
}