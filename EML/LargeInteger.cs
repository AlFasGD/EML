using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    /// <summary>Represents an arbitrarily large integer.</summary>
    public struct LargeInteger
    {
        List<byte> Bytes { get; set; }
        bool Sign { get; set; } // True = positive
        int Length { get { return Bytes.Count; } }

        #region Constructors
        public LargeInteger(byte b)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes((long)b));
            Sign = b >= 0;
        }
        public LargeInteger(short s)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes((long)s));
            Sign = s >= 0;
        }
        public LargeInteger(int i)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes((long)i));
            Sign = i >= 0;
        }
        public LargeInteger(long l)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes(l));
            Sign = l >= 0;
        }
        public LargeInteger(sbyte b)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes((long)b));
            Sign = b >= 0;
        }
        public LargeInteger(ushort s)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes((long)s));
            Sign = s >= 0;
        }
        public LargeInteger(uint i)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes((long)i));
            Sign = i >= 0;
        }
        public LargeInteger(ulong l)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes((long)l));
            Sign = l >= 0;
        }
        public LargeInteger(float f)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes((long)f));
            Sign = f >= 0;
        }
        public LargeInteger(double d)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes((long)d));
            Sign = d >= 0;
        }
        public LargeInteger(decimal d)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes((long)d));
            Sign = d >= 0;
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
        // Add more casts
        #endregion

        #region Operators
        public static LargeInteger operator +(LargeInteger left, LargeInteger right)
        {
            LargeInteger result = new LargeInteger();
            result.Bytes.AddRange(new byte[Math.Max(left.Length, right.Length)]); // Add as many bytes as needed for both the integers
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
                    result.Sign = left.Bytes[left.Length - 1] < right.Bytes[right.Length - 1];
            }
            else if (left.Sign && !right.Sign)
            {
                if (left.Length > right.Length)
                    result.Sign = true;
                else if (left.Length < right.Length)
                    result.Sign = false;
                else if (left.Length == right.Length)
                    result.Sign = left.Bytes[left.Length - 1] > right.Bytes[right.Length - 1];
            }
            for (int i = 0; i < result.Length; i++) // Insert the result per bytes
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
                {
                    if (left.Sign) // If the left number is positive
                        sum = left.Bytes[i];
                    else // If the left number is negative
                        sum = -left.Bytes[i];
                }
                else if (i >= left.Length && i < right.Length) // Only add the right number in the byte position if the byte index is out of range of the left number's byte list
                {
                    if (right.Sign) // If the right number is positive
                        sum = right.Bytes[i];
                    else // If the right number is negative
                        sum = -right.Bytes[i];
                }
                if (sum >= 256 - result.Bytes[i] && sum > 0) // If the sum is positive and bigger than the max value of a byte
                {
                    sum -= 256;
                    if (i < result.Length - 1) // If the next byte already exists in the list
                        result.Bytes[i + 1] += 1;
                    else if (i == result.Length - 1) // If there is a need for a new byte in the list
                        result.Bytes.Add(1);
                }
                else if (Math.Abs(sum) >= 256 - result.Bytes[i] && sum < 0) // If the sum is negative and its absolute value is bigger than the max value of a byte
                {
                    sum = Math.Abs(sum);
                    sum -= 256;
                    if (i < result.Length - 1) // If the next byte already exists in the list
                        result.Bytes[i + 1] += 1;
                    else if (i == result.Length - 1) // If there is a need for a new byte in the list
                        result.Bytes.Add(1);
                }
                result.Bytes[i] += (byte)sum;
            }
            return result;
        }
        public static LargeInteger operator -(LargeInteger left, LargeInteger right)
        {
            LargeInteger result = 0;
            // Code
            return result;
        }
        public static LargeInteger operator *(LargeInteger left, LargeInteger right)
        {
            LargeInteger result = 0;
            // Code
            return result;
        }
        public static LargeInteger operator /(LargeInteger left, LargeInteger right)
        {
            LargeInteger result = 0;
            // Code
            return result;
        }
        public static LargeInteger operator %(LargeInteger left, LargeInteger right)
        {
            LargeInteger result = 0;
            // Code
            return result;
        }
        public static LargeInteger operator >>(LargeInteger left, int right)
        {
            LargeInteger result = left;
            int remainingShifts = right;
            while (remainingShifts > 0)
            {
                int shifts = Math.Min(remainingShifts, 8);
                if (shifts < 8)
                {
                    for (int i = 0; i < result.Length - 1; i++)
                        result.Bytes[i] = (byte)(result.Bytes[i] >> shifts + result.Bytes[i + 1] << 8 - shifts);
                    result.Bytes[result.Length] = (byte)(result.Bytes[result.Length] >> shifts);
                }
                else if (shifts == 8)
                {
                    for (int i = 0; i < result.Length - 1; i++)
                        result.Bytes[i] = result.Bytes[i + 1];
                    result.Bytes.RemoveAt(result.Length);
                }
                remainingShifts -= shifts;
            }
            return result;
        }
        public static LargeInteger operator <<(LargeInteger left, int right)
        {
            LargeInteger result = left;
            int remainingShifts = right;
            while (remainingShifts > 0)
            {
                int shifts = Math.Min(remainingShifts, 8);
                result.Bytes.Add(0);
                if (shifts < 8)
                {
                    for (int i = result.Length - 1; i > 0; i--)
                        result.Bytes[i] = (byte)(result.Bytes[i - 1] << shifts + result.Bytes[i] >> 8 - shifts);
                    result.Bytes[0] = (byte)(result.Bytes[0] << shifts);
                }
                else if (shifts == 8)
                {
                    for (int i = result.Length - 1; i > 0; i--)
                        result.Bytes[i] = result.Bytes[i - 1];
                    result.Bytes[0] = 0;
                }
                remainingShifts -= shifts;
            }
            return result;
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
                    return left.Bytes[left.Length - 1] > right.Bytes[left.Length - 1];
            }
            else if (!left.Sign && !right.Sign)
            {
                if (left.Length < right.Length)
                    return true;
                else if (left.Length > right.Length)
                    return false;
                else
                    return left.Bytes[left.Length - 1] < right.Bytes[left.Length - 1];
            }
            else if (!left.Sign && right.Sign)
                return false;
            else
                return true;
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
                    return left.Bytes[left.Length - 1] < right.Bytes[left.Length - 1];
            }
            else if (!left.Sign && !right.Sign)
            {
                if (left.Length > right.Length)
                    return true;
                else if (left.Length < right.Length)
                    return false;
                else
                    return left.Bytes[left.Length - 1] > right.Bytes[left.Length - 1];
            }
            else if (!left.Sign && right.Sign)
                return true;
            else
                return false;
        }
        public static bool operator >=(LargeInteger left, LargeInteger right)
        {
            return left > right || left == right;
        }
        public static bool operator <=(LargeInteger left, LargeInteger right)
        {
            return left < right || left == right;
        }
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
                    if (left.Bytes[i] == right.Bytes[i])
                        return false;
            return true;
        }
        #endregion

        #region Operations
        #endregion

        #region Overrides
        public override string ToString()
        {
            string result = "";
            LargeInteger currentIntPart = this;
            for (LargeInteger i = 1; (currentIntPart = this / i) > 0; i *= 10)
                result = (char)((currentIntPart % 10) + 48) + result;
            return result;
        }
        #endregion
    }
}
