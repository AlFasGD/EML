using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

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
        /// <summary>An unlimited integer that is stored as plain text.</summary>
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
            /// <summary>Create a new instance of the PrecisionExponent struct.</summary>
            /// <param name="value">The value to parse to the PrecisionExponent.</param>
            public PrecisionExponent(decimal value)
            {
                Value = value;
                Exponent = 0;
                if (Value >= 10)
                    while (Value >= 10)
                    {
                        Value /= 10;
                        Exponent++;
                    }
                else if (Value < 1)
                    while (Value < 1)
                    {
                        Value *= 10;
                        Exponent--;
                    }
            }
            /// <summary>Create a new instance of the PrecisionExponent struct.</summary>
            /// <param name="value">The value to parse to the PrecisionExponent.</param>
            /// <param name="exponent">The exponent of the value to parse to the PrecisionExponent.</param>
            public PrecisionExponent(decimal value, BigInteger exponent)
            {
                Value = value;
                Exponent = exponent;
                if (Value >= 10)
                    while (Value >= 10)
                    {
                        Value /= 10;
                        Exponent++;
                    }
                else if (Value < 1)
                    while (Value < 1)
                    {
                        Value *= 10;
                        Exponent--;
                    }
            }
            #endregion
            /// <summary>Sets the parsed values as they are supposed to be in the <see cref="PrecisionExponent"/> struct and returns them.</summary>
            /// <param name="inputValue">The value that will be processed in the <see cref="PrecisionExponent"/>.</param>
            /// <param name="inputExponent">The exponent that will be processed in the <see cref="PrecisionExponent"/>.</param>
            /// <param name="value">The output value as changed in the <see cref="PrecisionExponent"/>.</param>
            /// <param name="exponent">The output exponent as changed in the <see cref="PrecisionExponent"/>.</param>
            static void GetPrecisionExponentInfo(decimal inputValue, BigInteger inputExponent, out decimal value, out BigInteger exponent)
            {
                value = inputValue;
                exponent = inputExponent;
                if (value >= 10)
                    while (value >= 10)
                    {
                        value /= 10;
                        exponent++;
                    }
                else if (value < 1)
                    while (value < 1)
                    {
                        value *= 10;
                        exponent--;
                    }
            }
            /// <summary>Returns a new <see cref="PrecisionExponent"/> object with the proper values.</summary>
            /// <param name="input">The <see cref="PrecisionExponent"/> to get the info from.</param>
            /// <param name="output">The <see cref="PrecisionExponent"/> that will be changed.</param>
            static void GetPrecisionExponentInfo(PrecisionExponent input, out PrecisionExponent output)
            {
                output = input;
                if (output.Value >= 10)
                    while (output.Value >= 10)
                    {
                        output.Value /= 10;
                        output.Exponent++;
                    }
                else if (output.Value < 1)
                    while (output.Value < 1)
                    {
                        output.Value *= 10;
                        output.Exponent--;
                    }
            }
            #region Operators
            /// <summary>Adds the values of the two <see cref="PrecisionExponent"/> objects and returns their sum.</summary>
            public static PrecisionExponent operator +(PrecisionExponent left, PrecisionExponent right)
            {
                BigInteger times = right.Exponent - left.Exponent;
                for (BigInteger i = 1; i < times; i++)
                    right.Value /= 10;
                PrecisionExponent result = new PrecisionExponent(left.Value + right.Value, left.Exponent);
                return result;
            }
            /// <summary>Subtracts the value of the second <see cref="PrecisionExponent"/> object from the value of the first <see cref="PrecisionExponent"/> object and returns their difference.</summary>
            public static PrecisionExponent operator -(PrecisionExponent left, PrecisionExponent right)
            {
                BigInteger times = right.Exponent - left.Exponent;
                for (BigInteger i = 1; i < times; i++)
                    right.Value /= 10;
                PrecisionExponent result = new PrecisionExponent(left.Value - right.Value, left.Exponent);
                return result;
            }
            /// <summary>Multiplies the value of the first <see cref="PrecisionExponent"/> object with the value of the second <see cref="PrecisionExponent"/> object and returns the product.</summary>
            public static PrecisionExponent operator *(PrecisionExponent left, PrecisionExponent right)
            {
                PrecisionExponent result = new PrecisionExponent(left.Value * right.Value, left.Exponent + right.Exponent);
                return result;
            }
            /// <summary>Divides the value of the first <see cref="PrecisionExponent"/>object by the value of the second <see cref="PrecisionExponent"/> object and returns the result.</summary>
            public static PrecisionExponent operator /(PrecisionExponent left, PrecisionExponent right)
            {
                if (right.Value != 0)
                {
                    PrecisionExponent result = new PrecisionExponent(left.Value / right.Value, left.Exponent - right.Exponent);
                    return result;
                }
                else throw new DivideByZeroException("Cannot divide by zero.");
            }
            /// <summary>Returns whether the value of the first <see cref="PrecisionExponent"/> object is greater than the value of the second <see cref="PrecisionExponent"/> object.</summary>
            public static bool operator >(PrecisionExponent left, PrecisionExponent right)
            {
                if (left.Exponent == right.Exponent)
                    return left.Value > right.Value;
                return left.Exponent > right.Exponent;
            }
            /// <summary>Returns whether the value of the first <see cref="PrecisionExponent"/> object is smaller than the value of the second <see cref="PrecisionExponent"/> object.</summary>
            public static bool operator <(PrecisionExponent left, PrecisionExponent right)
            {
                if (left.Exponent == right.Exponent)
                    return left.Value < right.Value;
                return left.Exponent < right.Exponent;
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

            #region Operations
            public static PrecisionExponent Power(PrecisionExponent p, double power)
            {
                PrecisionExponent result = p;
                result.Value = (decimal)Math.Pow((double)result.Value, power);
                result.Value *= (decimal)Math.Pow(10, power - (int)power);
                result.Exponent *= (int)power;
                GetPrecisionExponentInfo(result, out PrecisionExponent res);
                return res;
            }
            public static PrecisionExponent Reverse(PrecisionExponent p) => One / p;
            #endregion
            #region Constant Fields
            public static PrecisionExponent Zero { get { return new PrecisionExponent(0); } }
            public static PrecisionExponent One { get { return new PrecisionExponent(1); } }
            #endregion
        }
    }
}