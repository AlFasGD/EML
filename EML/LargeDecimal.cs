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
        public int Length { get { return LeftBytes.Count + RightBytes.Count; } }
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
        public LargeDecimal(byte[] b)
        {
            LeftBytes = new List<byte>();
            LeftBytes.AddRange(b);
            RightBytes = new List<byte>();
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
        #endregion
        #region Operators
        public static LargeDecimal operator -(LargeDecimal l)
        {
            l.Sign = !l.Sign;
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
            if (left.LeftLength != left.RightLength && right.Length != right.RightLength)
                return false;
            else if (left.LeftLength == left.RightLength && right.Length == right.RightLength)
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
            if (left.LeftLength != left.RightLength && right.Length != right.RightLength)
                return true;
            else if (left.LeftLength == left.RightLength && right.Length == right.RightLength)
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
                for (int i = str.Length - 1; i >= 0; i--)
                    result += str[i] * Power(10, i - str.Length + 1);
            }
            else throw new FormatException("The string represents no numerical value.");
            return result;
        }
        
        #endregion
    }
}