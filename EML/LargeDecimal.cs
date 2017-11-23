using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    public struct LargeDecimal
    {
        public List<byte> LeftBytes { get; set; } // The bytes for the left part of the decimal number
        public List<byte> RightBytes { get; set; } // The bytes for the right part of the decimal number (after the decimal point)
        public bool Sign { get; set; } // True = positive
        //public int Length { get { return LeftBytes.Count + RightBytes.Count; } }
        public int LeftLength { get { return LeftBytes.Count; } }
        public int RightLength { get { return RightBytes.Count; } }
        
        #region Constructors
        public LargeDecimal(byte b)
        {
            LeftBytes = new List<byte>();
            LeftBytes.AddRange(BitConverter.GetBytes((long)b));
            RightBytes = new List<byte>();
            Sign = true;
        }
        public LargeDecimal(short s)
        {
            LeftBytes = new List<byte>();
            LeftBytes.AddRange(BitConverter.GetBytes((long)s));
            RightBytes = new List<byte>();
            Sign = s >= 0;
        }
        public LargeDecimal(int i)
        {
            LeftBytes = new List<byte>();
            LeftBytes.AddRange(BitConverter.GetBytes((long)i));
            RightBytes = new List<byte>();
            Sign = i >= 0;
        }
        public LargeDecimal(long l)
        {
            LeftBytes = new List<byte>();
            LeftBytes.AddRange(BitConverter.GetBytes(l));
            RightBytes = new List<byte>();
            Sign = l >= 0;
        }
        public LargeDecimal(sbyte b)
        {
            LeftBytes = new List<byte>();
            LeftBytes.AddRange(BitConverter.GetBytes((long)b));
            RightBytes = new List<byte>();
            Sign = b >= 0;
        }
        public LargeDecimal(ushort s)
        {
            LeftBytes = new List<byte>();
            LeftBytes.AddRange(BitConverter.GetBytes((long)s));
            RightBytes = new List<byte>();
            Sign = s >= 0;
        }
        public LargeDecimal(uint i)
        {
            LeftBytes = new List<byte>();
            LeftBytes.AddRange(BitConverter.GetBytes((long)i));
            RightBytes = new List<byte>();
            Sign = i >= 0;
        }
        public LargeDecimal(ulong l)
        {
            LeftBytes = new List<byte>();
            LeftBytes.AddRange(BitConverter.GetBytes((long)l));
            RightBytes = new List<byte>();
            Sign = l >= 0;
        }
        public LargeDecimal(float f)
        {
            LargeDecimal a = Parse(f.ToString());
            LeftBytes = a.LeftBytes;
            RightBytes = a.RightBytes;
            Sign = a.Sign;
        }
        public LargeDecimal(double d)
        {
            LargeDecimal a = Parse(d.ToString());
            LeftBytes = a.LeftBytes;
            RightBytes = a.RightBytes;
            Sign = a.Sign;
        }
        public LargeDecimal(decimal d)
        {
            LargeDecimal a = Parse(d.ToString());
            LeftBytes = a.LeftBytes;
            RightBytes = a.RightBytes;
            Sign = a.Sign;
        }
        public LargeDecimal(LargeInteger l)
        {
            LeftBytes = l.Bytes;
            RightBytes = new List<byte>();
            Sign = l.Sign;
        }
        public LargeDecimal(byte[] leftBytes, byte[] rightBytes)
        {
            LeftBytes = new List<byte>();
            LeftBytes.AddRange(leftBytes);
            RightBytes = new List<byte>();
            RightBytes.AddRange(rightBytes);
            Sign = true;
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
            LargeDecimal result = new LargeDecimal();
            result.LeftBytes.AddRange(new byte[Math.Max(left.LeftLength, right.LeftLength)]); // Add as many left bytes as needed for both the decimals
            result.RightBytes.AddRange(new byte[Math.Max(left.RightLength, right.RightLength)]); // Add as many right bytes as needed for both the decimals
            if (!left.Sign && !right.Sign)
                result.Sign = false;
            else if (left.Sign && right.Sign)
                result.Sign = true;
            else if (!left.Sign && right.Sign)
            {
                if (left.RightLength > right.RightLength)
                    result.Sign = false;
                else if (left.RightLength < right.RightLength)
                    result.Sign = true;
                else if (left.RightLength == 0 && right.RightLength == 0)
                    result.Sign = left.LeftBytes[0] < right.LeftBytes[0];
                else if (left.RightLength == right.RightLength)
                    result.Sign = left.RightBytes[left.RightLength - 1] < right.RightBytes[right.RightLength - 1];
            }
            else if (left.Sign && !right.Sign)
            {
                if (left.RightLength > right.RightLength)
                    result.Sign = true;
                else if (left.RightLength < right.RightLength)
                    result.Sign = false;
                else if (left.RightLength == 0 && right.RightLength == 0)
                    result.Sign = left.LeftBytes[0] > right.LeftBytes[0];
                else if (left.RightLength == right.RightLength)
                    result.Sign = left.RightBytes[left.RightLength - 1] > right.RightBytes[right.RightLength - 1];
            }
            for (int i = result.RightLength; i >= 0; i--) // Insert the result per bytes
            {
                int sum = 0;
                if (i < left.RightLength && i < right.RightLength) // Add both numbers in the sum if the byte positions are in the bounds of both numbers' byte list
                {
                    if (left.Sign && right.Sign) // If both numbers are positive
                        sum = left.RightBytes[i] + right.RightBytes[i];
                    else if (!left.Sign && right.Sign) // If the left number is negative and the other is positive
                        sum = right.RightBytes[i] - left.RightBytes[i];
                    else if (left.Sign && !right.Sign) // If the right number is negative and the other is positive
                        sum = left.RightBytes[i] - right.RightBytes[i];
                    else if (!left.Sign && !right.Sign) // If both numbers are negative
                        sum = -left.RightBytes[i] - right.RightBytes[i];
                }
                else if (i < left.RightLength && i >= right.RightLength) // Only add the left number in the byte position if the byte index is out of range of the right number's byte list
                {
                    if (left.Sign) // If the left number is positive
                        sum = left.RightBytes[i];
                    else // If the left number is negative
                        sum = -left.RightBytes[i];
                }
                else if (i >= left.RightLength && i < right.RightLength) // Only add the right number in the byte position if the byte index is out of range of the left number's byte list
                {
                    if (right.Sign) // If the right number is positive
                        sum = right.RightBytes[i];
                    else // If the right number is negative
                        sum = -right.RightBytes[i];
                }
                if (sum >= 256 - result.RightBytes[i] && sum > 0) // If the sum is positive and bigger than the max value of a byte
                {
                    sum -= 256;
                    int j = i - 1;
                    do
                    {
                        result.RightBytes[j]++;
                        j++;
                    }
                    while (result.RightBytes[j] == 0 && j >= 0);
                    if (result.RightBytes[0] == 0 && j == -1) // If there is a need to increase the left part of the number
                    {
                        j = 0;
                        do
                        {
                            result.LeftBytes[j]++;
                            j++;
                        }
                        while (result.LeftBytes[j] == 0 && j < result.LeftLength);
                        if (result.LeftBytes[result.LeftLength - 1] == 0 && j == result.LeftLength) // If there is a need for a new byte in the list
                            result.LeftBytes.Add(1);
                    }
                }
                else if (Math.Abs(sum) >= 256 - result.RightBytes[i] && sum < 0) // If the sum is negative and its absolute value is bigger than the max value of a byte
                {
                    sum = Math.Abs(sum);
                    sum -= 256;
                    if (i > 0) // If the next byte is still on the right side
                        result.RightBytes[i - 1]++;
                    else if (i == 0) // If the next byte is on the left side
                    {
                        if (result.RightLength > 0) // If the byte on the left side already exists
                            result.RightBytes[0]++;
                        else if (result.RightLength == 0) // If the byte on the right side does not exist
                            result.RightBytes.Add(1);
                    }
                }
                result.RightBytes[i] += (byte)sum;
            }
            for (int i = 0; i < result.LeftLength; i++) // Insert the result per bytes
            {
                int sum = 0;
                if (i < left.LeftLength && i < right.LeftLength) // Add both numbers in the sum if the byte positions are in the bounds of both numbers' byte list
                {
                    if (left.Sign && right.Sign) // If both numbers are positive
                        sum = left.LeftBytes[i] + right.LeftBytes[i];
                    else if (!left.Sign && right.Sign) // If the left number is negative and the other is positive
                        sum = right.LeftBytes[i] - left.LeftBytes[i];
                    else if (left.Sign && !right.Sign) // If the right number is negative and the other is positive
                        sum = left.LeftBytes[i] - right.LeftBytes[i];
                    else if (!left.Sign && !right.Sign) // If both numbers are negative
                        sum = -left.LeftBytes[i] - right.LeftBytes[i];
                }
                else if (i < left.LeftLength && i >= right.LeftLength) // Only add the left number in the byte position if the byte index is out of range of the right number's byte list
                {
                    if (left.Sign) // If the left number is positive
                        sum = left.LeftBytes[i];
                    else // If the left number is negative
                        sum = -left.LeftBytes[i];
                }
                else if (i >= left.LeftLength && i < right.LeftLength) // Only add the right number in the byte position if the byte index is out of range of the left number's byte list
                {
                    if (right.Sign) // If the right number is positive
                        sum = right.LeftBytes[i];
                    else // If the right number is negative
                        sum = -right.LeftBytes[i];
                }
                if (sum >= 256 - result.LeftBytes[i] && sum > 0) // If the sum is positive and bigger than the max value of a byte
                {
                    sum -= 256;
                    if (i < result.LeftLength - 1) // If the next byte already exists in the list
                        result.LeftBytes[i + 1]++;
                    else if (i == result.LeftLength - 1) // If there is a need for a new byte in the list
                        result.LeftBytes.Add(1);
                }
                else if (Math.Abs(sum) >= 256 - result.LeftBytes[i] && sum < 0) // If the sum is negative and its absolute value is bigger than the max value of a byte
                {
                    sum = Math.Abs(sum);
                    int j = i + 1;
                    do
                    {
                        result.LeftBytes[j]++;
                        j++;
                    }
                    while (result.LeftBytes[j] == 0 && j < result.LeftLength);
                    if (result.LeftBytes[result.LeftLength - 1] == 0 && j == result.LeftLength) // If there is a need for a new byte in the list
                        result.LeftBytes.Add(1);
                }
                result.LeftBytes[i] += (byte)sum;
            }
            return result;
        }
        public static LargeDecimal operator -(LargeDecimal left, LargeDecimal right) => left + (-right);
        public static LargeDecimal operator *(LargeDecimal left, LargeDecimal right)
        {
            // TODO: Work on this, add some details in the algorithm
            LargeDecimal result = 0;
            result.Sign = left.Sign == right.Sign;
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
        public static LargeDecimal operator /(LargeDecimal left, LargeDecimal right)
        {
            // TODO: Work on this
            LargeDecimal result = 0;
            result.Sign = left.Sign == right.Sign;
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
        public static LargeDecimal operator >>(LargeDecimal left, int right)
        {
            LargeDecimal result = left;
            int shifts = right % 8;
            int fullShifts = right / 8;
            for (int i = 0; i < fullShifts; i++)
                result.RightBytes.Add(result.RightBytes[i - fullShifts]);
            if (fullShifts > 0)
            {
                for (int i = result.RightLength - 1; i > 0; i--)
                    result.RightBytes[i] = result.RightBytes[i - 1];
                if (result.LeftLength > 0)
                {
                    result.RightBytes[0] = result.LeftBytes[0];
                    for (int i = 0; i < result.LeftLength - 1; i++)
                        result.LeftBytes[i] = result.LeftBytes[i + 1];
                }
                if (fullShifts <= result.LeftLength)
                    result.LeftBytes.RemoveRange(result.LeftLength - fullShifts, fullShifts);
                else
                {
                    fullShifts -= result.LeftLength;
                    result.LeftBytes.Clear();
                    result.RightBytes.RemoveRange(result.RightLength - fullShifts, fullShifts);
                }
            }
            if (shifts > 0)
            {
                for (int i = result.RightLength - 1; i > 0; i--)
                    result.RightBytes[i] = (byte)((result.RightBytes[i - 1] << (8 - shifts) + (result.RightBytes[i] >> shifts)));
                if (result.LeftLength > 0)
                {
                    result.RightBytes[0] = (byte)((result.LeftBytes[0] << (8 - shifts) + (result.RightBytes[0] >> shifts))); // Shift the bytes between the decimal point
                    for (int i = 0; i < result.LeftLength - 1; i++)
                        result.LeftBytes[i] = (byte)((result.LeftBytes[i + 1] << (8 - shifts) + (result.LeftBytes[i] >> shifts)));
                    result.LeftBytes[result.LeftLength - 1] = (byte)(result.LeftBytes[result.LeftLength - 1] >> shifts);
                }
            }
            return result;
        }
        public static LargeDecimal operator <<(LargeDecimal left, int right)
        {
            // TODO: Work on this by changing some details in the operation
            LargeDecimal result = left;
            int shifts = right % 8;
            int fullShifts = right / 8;
            for (int i = 0; i < fullShifts; i++)
                result.LeftBytes.Add(result.LeftBytes[i - fullShifts]);
            if (fullShifts > 0)
            {
                for (int i = result.LeftLength - 1; i > 0; i--)
                    result.LeftBytes[i] = result.LeftBytes[i - 1];
                if (result.RightLength > 0)
                {
                    result.LeftBytes[0] = result.RightBytes[0];
                    for (int i = 0; i < result.RightLength - 1; i++)
                        result.RightBytes[i] = result.RightBytes[i + 1];
                }
                if (fullShifts <= result.RightLength)
                    result.RightBytes.RemoveRange(result.RightLength - fullShifts, fullShifts);
                else
                {
                    fullShifts -= result.RightLength;
                    result.RightBytes.Clear();
                    result.LeftBytes.RemoveRange(result.LeftLength - fullShifts, fullShifts);
                }
            }
            if (shifts > 0)
            {
                for (int i = result.LeftLength - 1; i > 0; i--)
                    result.LeftBytes[i] = (byte)((result.LeftBytes[i - 1] >> (8 - shifts) + (result.LeftBytes[i] << shifts)));
                if (result.RightLength > 0)
                {
                    result.LeftBytes[0] = (byte)((result.RightBytes[0] >> (8 - shifts) + (result.LeftBytes[0] << shifts))); // Shift the bytes between the decimal point
                    for (int i = 0; i < result.RightLength - 1; i++)
                        result.RightBytes[i] = (byte)((result.RightBytes[i + 1] >> (8 - shifts) + (result.RightBytes[i] << shifts)));
                    result.RightBytes[result.RightLength - 1] = (byte)(result.RightBytes[result.RightLength - 1] << shifts);
                }
            }
            return result;
        }
        public static LargeDecimal operator -(LargeDecimal l)
        {
            l.Sign = !l.Sign;
            return l;
        }
        public static LargeDecimal operator &(LargeDecimal left, LargeDecimal right)
        {
            int minLeftLength = Math.Min(left.LeftLength, right.LeftLength);
            int minRightLength = Math.Min(left.RightLength, right.RightLength);
            byte[] leftBytes = new byte[minLeftLength];
            byte[] rightBytes = new byte[minRightLength];
            for (int i = 0; i < minLeftLength; i++)
                leftBytes[i] = (byte)(left.LeftBytes[i] & right.LeftBytes[i]);
            for (int i = 0; i < minRightLength; i++)
                rightBytes[i] = (byte)(left.RightBytes[i] & right.RightBytes[i]);
            return new LargeDecimal(leftBytes, rightBytes);
        }
        public static LargeDecimal operator |(LargeDecimal left, LargeDecimal right)
        {
            int minLeftLength = Math.Min(left.LeftLength, right.LeftLength);
            int minRightLength = Math.Min(left.RightLength, right.RightLength);
            int maxLeftLength = Math.Max(left.LeftLength, right.LeftLength);
            int maxRightLength = Math.Max(left.RightLength, right.RightLength);
            byte[] leftBytes = new byte[minLeftLength];
            byte[] rightBytes = new byte[minRightLength];
            for (int i = 0; i < minLeftLength; i++)
                leftBytes[i] = (byte)(left.LeftBytes[i] | right.LeftBytes[i]);
            for (int i = 0; i < minRightLength; i++)
                rightBytes[i] = (byte)(left.RightBytes[i] | right.RightBytes[i]);
            if (left.LeftLength > right.LeftLength)
                for (int i = minLeftLength; i < maxLeftLength; i++)
                    leftBytes[i] = left.LeftBytes[i];
            else
                for (int i = minLeftLength; i < maxLeftLength; i++)
                    leftBytes[i] = right.LeftBytes[i];
            if (right.RightLength > right.RightLength)
                for (int i = minRightLength; i < maxRightLength; i++)
                    rightBytes[i] = right.RightBytes[i];
            else
                for (int i = minRightLength; i < maxRightLength; i++)
                    rightBytes[i] = right.RightBytes[i];
            return new LargeDecimal(leftBytes, rightBytes);
        }
        public static LargeDecimal operator ^(LargeDecimal left, LargeDecimal right)
        {
            int minLeftLength = Math.Min(left.LeftLength, right.LeftLength);
            int minRightLength = Math.Min(left.RightLength, right.RightLength);
            int maxLeftLength = Math.Max(left.LeftLength, right.LeftLength);
            int maxRightLength = Math.Max(left.RightLength, right.RightLength);
            byte[] leftBytes = new byte[minLeftLength];
            byte[] rightBytes = new byte[minRightLength];
            for (int i = 0; i < minLeftLength; i++)
                leftBytes[i] = (byte)(left.LeftBytes[i] ^ right.LeftBytes[i]);
            for (int i = 0; i < minRightLength; i++)
                rightBytes[i] = (byte)(left.RightBytes[i] ^ right.RightBytes[i]);
            if (left.LeftLength > right.LeftLength)
                for (int i = minLeftLength; i < maxLeftLength; i++)
                    leftBytes[i] = left.LeftBytes[i];
            else
                for (int i = minLeftLength; i < maxLeftLength; i++)
                    leftBytes[i] = right.LeftBytes[i];
            if (right.RightLength > right.RightLength)
                for (int i = minRightLength; i < maxRightLength; i++)
                    rightBytes[i] = right.RightBytes[i];
            else
                for (int i = minRightLength; i < maxRightLength; i++)
                    rightBytes[i] = right.RightBytes[i];
            return new LargeDecimal(leftBytes, rightBytes);
        }
        public static LargeDecimal operator ~(LargeDecimal l)
        {
            for (int i = 0; i < l.RightLength; i++)
                l.RightBytes[i] = (byte)~l.RightBytes[i];
            for (int i = 0; i < l.LeftLength; i++)
                l.LeftBytes[i] = (byte)~l.LeftBytes[i];
            return l;
        }
        public static bool operator >(LargeDecimal left, LargeDecimal right)
        {
            if (left.Sign && right.Sign)
            {
                if (left.LeftLength > right.LeftLength)
                    return true;
                else if (left.LeftLength < right.LeftLength)
                    return false;
                else
                    for (int i = left.LeftLength - 1; i >= 0; i--)
                        if (left.LeftBytes[left.LeftLength - 1] > right.LeftBytes[left.LeftLength - 1])
                            return true;
                return false;
            }
            else if (!left.Sign && !right.Sign)
            {
                if (left.LeftLength < right.LeftLength)
                    return true;
                else if (left.LeftLength > right.LeftLength)
                    return false;
                else
                    for (int i = left.LeftLength - 1; i >= 0; i--)
                        if (left.LeftBytes[left.LeftLength - 1] < right.LeftBytes[left.LeftLength - 1])
                            return true;
                return false;
            }
            else if (!left.Sign && right.Sign)
                return false;
            else
                return true;
        }
        public static bool operator <(LargeDecimal left, LargeDecimal right)
        {
            if (left.Sign && right.Sign)
            {
                if (left.LeftLength < right.LeftLength)
                    return true;
                else if (left.LeftLength > right.LeftLength)
                    return false;
                else
                    for (int i = left.LeftLength - 1; i >= 0; i--)
                        if (left.LeftBytes[left.LeftLength - 1] < right.LeftBytes[left.LeftLength - 1])
                            return true;
                return false;
            }
            else if (!left.Sign && !right.Sign)
            {
                if (left.LeftLength > right.LeftLength)
                    return true;
                else if (left.LeftLength < right.LeftLength)
                    return false;
                else
                    for (int i = left.LeftLength - 1; i >= 0; i--)
                        if (left.LeftBytes[left.LeftLength - 1] > right.LeftBytes[left.LeftLength - 1])
                            return true;
                return false;
            }
            else if (!left.Sign && right.Sign)
                return true;
            else
                return false;
        }
        public static bool operator >=(LargeDecimal left, LargeDecimal right) => left > right || left == right;
        public static bool operator <=(LargeDecimal left, LargeDecimal right) => left < right || left == right;
        public static bool operator ==(LargeDecimal left, LargeDecimal right)
        {
            if (left.LeftLength != left.RightLength && right.LeftLength != right.RightLength)
                return false;
            else if (left.LeftLength == left.RightLength && right.LeftLength == right.RightLength)
            {
                for (int i = 0; i < left.LeftLength; i++)
                    if (left.LeftBytes[i] != right.LeftBytes[i])
                        return false;
                for (int i = 0; i < left.RightLength; i++)
                    if (left.RightBytes[i] != right.RightBytes[i])
                        return false;
            }
            return true;
        }
        public static bool operator !=(LargeDecimal left, LargeDecimal right)
        {
            if (left.LeftLength != left.RightLength && right.LeftLength != right.RightLength)
                return true;
            else if (left.LeftLength == left.RightLength && right.LeftLength == right.RightLength)
            {
                for (int i = 0; i < left.LeftLength; i++)
                    if (left.LeftBytes[i] == right.LeftBytes[i])
                        return false;
                for (int i = 0; i < left.RightLength; i++)
                    if (left.RightBytes[i] == right.RightBytes[i])
                        return false;
            }
            return true;
        }
        #endregion
        #region Operations
        public static bool TryParse(string str, out LargeDecimal result)
        {
            result = 0;
            try { result = Parse(str); }
            catch (FormatException) { return false; }
            return true;
        }
        public static LargeDecimal AbsoluteValue(LargeDecimal l) => l >= 0 ? l : -l;
        public static LargeDecimal Invert(LargeDecimal l) => 1 / l;
        public static LargeDecimal Parse(string str)
        {
            LargeDecimal result = 0;
            if (str[0] != 45) // If it's not a number character
            {
                str = str.Remove(0, 1);
                result.Sign = false;
            }
            string[] split = str.Split('.');
            if (str.Length > 0 && split.Length <= 2)
            {
                result.LeftBytes = LargeInteger.Parse(split[0]).Bytes;
                for (int i = 0; i < split[1].Length; i++)
                    if (str[i] < 48 || str[i] > 57) // If it's not a number character
                        throw new FormatException("The string is not a valid numerical value.");
                for (int i = split[0].Length - 1; i >= 0; i--)
                    result += split[0][i] * Power(10, i - split[0].Length + 1);
            }
            else throw new FormatException("The string represents no numerical value.");
            return result;
        }
        public static LargeDecimal Power(LargeDecimal b, LargeDecimal power)
        {
            LargeDecimal result = 1;
            // Algorithm to return the power of a number
            return result;
        }
        #endregion
    }
}