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
        public List<byte> Bytes { get; set; }
        public bool Sign { get; set; } // True if number is positive
        public int Length { get { return Bytes.Count; } }

        #region Constructors
        public LargeInteger(byte b)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes((long)b));
            Sign = true;
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
            LargeInteger n = Parse(d.ToString());
            Bytes = n.Bytes;
            Sign = n.Sign;
        }
        public LargeInteger(LargeDecimal d)
        {
            Bytes = d.RightBytes;
            Sign = d.Sign;
        }
        public LargeInteger(byte[] b)
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
                    int j = i + 1;
                    do
                    {
                        result.Bytes[j]++;
                        j++;
                    }
                    while (result.Bytes[j] == 0 && j < result.Length);
                    if (result.Bytes[result.Length - 1] == 0 && j == result.Length) // If there is a need for a new byte in the list
                        result.Bytes.Add(1);
                }
                else if (Math.Abs(sum) >= 256 - result.Bytes[i] && sum < 0) // If the sum is negative and its absolute value is bigger than the max value of a byte
                {
                    sum = Math.Abs(sum);
                    int j = i + 1;
                    do
                    {
                        result.Bytes[j]++;
                        j++;
                    }
                    while (result.Bytes[j] == 0 && j < result.Length);
                    if (result.Bytes[result.Length - 1] == 0 && j == result.Length) // If there is a need for a new byte in the list
                        result.Bytes.Add(1);
                }
                result.Bytes[i] += (byte)sum;
            }
            return result;
        }
        public static LargeInteger operator -(LargeInteger left, LargeInteger right) => left + (-right);
        public static LargeInteger operator *(LargeInteger left, LargeInteger right)
        {
            LargeInteger result = 0;
            result.Sign = left.Sign == right.Sign;
            left = AbsoluteValue(left);
            right = AbsoluteValue(right);
            while (right > 0)
            {
                LargeInteger temp = (right >> 1) << 1;
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
        public static LargeInteger operator /(LargeInteger left, LargeInteger right)
        {
            if (right != 0)
            {
                if (AbsoluteValue(left) == AbsoluteValue(right))
                {
                    if (left.Sign == right.Sign)
                        return 1;
                    else
                        return -1;
                }
                else if (AbsoluteValue(left) < AbsoluteValue(right))
                    return 0;
                else
                {
                    LargeInteger result = 0;
                    result.Sign = left.Sign == right.Sign;
                    left = AbsoluteValue(left);
                    right = AbsoluteValue(right);
                    LargeInteger num_bits = left.Length * 8;
                    LargeInteger t, q, bit, d = 0;
                    LargeInteger remainder = 0;
                    while (remainder < right)
                    {
                        bit = (left & 0x80000000) >> (left.Length * 8 - 1);
                        remainder = (remainder << 1) | bit;
                        d = left;
                        left = left << 1;
                        num_bits--;
                    }

                    /* The loop, above, always goes one iteration too far.
                       To avoid inserting an "if" statement inside the loop
                       the last iteration is simply reversed. */

                    left = d;
                    remainder = remainder >> 1;
                    num_bits++;

                    for (LargeInteger i = 0; i < num_bits; i++)
                    {
                        bit = (left & 0x80000000) >> (left.Length * 8 - 1);
                        remainder = (remainder << 1) | bit;
                        t = remainder - right;
                        q = ~((t & 0x80000000) >> (left.Length * 8 - 1));
                        left = left << 1;
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
                if (AbsoluteValue(left) == AbsoluteValue(right))
                {
                    if (left.Sign == right.Sign)
                        return 1;
                    else
                        return -1;
                }
                else if (AbsoluteValue(left) < AbsoluteValue(right))
                    return 0;
                else
                {
                    LargeInteger result = 0;
                    result.Sign = left.Sign == right.Sign;
                    left = AbsoluteValue(left);
                    right = AbsoluteValue(right);
                    LargeInteger num_bits = left.Length * 8;
                    LargeInteger t, q, bit, d = 0;
                    LargeInteger remainder = 0;
                    while (remainder < right)
                    {
                        bit = (left & 0x80000000) >> (left.Length * 8 - 1);
                        remainder = (remainder << 1) | bit;
                        d = left;
                        left = left << 1;
                        num_bits--;
                    }

                    /* The loop, above, always goes one iteration too far.
                       To avoid inserting an "if" statement inside the loop
                       the last iteration is simply reversed. */

                    left = d;
                    remainder = remainder >> 1;
                    num_bits++;

                    for (LargeInteger i = 0; i < num_bits; i++)
                    {
                        bit = (left & 0x80000000) >> (left.Length * 8 - 1);
                        remainder = (remainder << 1) | bit;
                        t = remainder - right;
                        q = ~((t & 0x80000000) >> (left.Length * 8 - 1));
                        left = left << 1;
                        result = (result << 1) | q;
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
                result.Bytes[result.Length] = (byte)(result.Bytes[result.Length] >> shifts);
            }
            return result;
        }
        public static LargeInteger operator <<(LargeInteger left, int right)
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
                    result.Bytes[i] = (byte)((result.Bytes[i - 1] << shifts) + (result.Bytes[i] >> (8 - shifts)));
                result.Bytes[fullShifts] = (byte)(result.Bytes[fullShifts] << shifts);
            }
            return result;
        }
        public static LargeInteger operator -(LargeInteger l)
        {
            l.Sign = !l.Sign;
            return l;
        }
        public static LargeInteger operator &(LargeInteger left, LargeInteger right)
        {
            int minLength = Math.Min(left.Length, right.Length);
            byte[] bytes = new byte[minLength];
            for (int i = 0; i < minLength; i++)
                bytes[i] = (byte)(left.Bytes[i] & right.Bytes[i]);
            return new LargeInteger(bytes);
        }
        public static LargeInteger operator |(LargeInteger left, LargeInteger right)
        {
            int minLength = Math.Min(left.Length, right.Length);
            int maxLength = Math.Max(left.Length, right.Length);
            byte[] bytes = new byte[maxLength];
            for (int i = 0; i < minLength; i++)
                bytes[i] = (byte)(left.Bytes[i] | right.Bytes[i]);
            if (left.Length > right.Length)
                for (int i = minLength; i < maxLength; i++)
                    bytes[i] = left.Bytes[i];
            else
                for (int i = minLength; i < maxLength; i++)
                    bytes[i] = right.Bytes[i];
            return new LargeInteger(bytes);
        }
        public static LargeInteger operator ^(LargeInteger left, LargeInteger right)
        {
            int minLength = Math.Min(left.Length, right.Length);
            int maxLength = Math.Max(left.Length, right.Length);
            byte[] bytes = new byte[maxLength];
            for (int i = 0; i < minLength; i++)
                bytes[i] = (byte)(left.Bytes[i] ^ right.Bytes[i]);
            if (left.Length > right.Length)
                for (int i = minLength; i < maxLength; i++)
                    bytes[i] = left.Bytes[i];
            else
                for (int i = minLength; i < maxLength; i++)
                    bytes[i] = right.Bytes[i];
            return new LargeInteger(bytes);
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
            else if (!left.Sign && right.Sign)
                return true;
            else
                return false;
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
                    if (left.Bytes[i] == right.Bytes[i])
                        return false;
            return true;
        }
        #endregion
        #region Operations
        public static bool IsPrime(LargeInteger l)
        {
            bool result = false;
            LargeInteger sqrt = SquareRoot(l);
            for (int i = 2; i <= sqrt; i++)
                if (l % i == 0)
                    break;
                else result = i == sqrt;
            return result;
        }
        public static bool TryParse(string str, out LargeInteger result)
        {
            result = 0;
            try { result = Parse(str); }
            catch { return false; }
            return true;
        }
        public static int GetDecimalDigitCount(LargeInteger l)
        {
            int digCount = (l.Length - 1) * 2 + 1;
            for (int i = digCount; i < l.Length * 3; i++)
                if (l % Power(10, i) > 0)
                    digCount = i;
            return digCount;
        }
        public static LargeInteger AbsoluteValue(LargeInteger l) => l >= 0 ? l : -l;
        public static LargeInteger GreatestCommonDivisor(LargeInteger a, LargeInteger b)
        {
            LargeInteger max = Max(a, b);
            LargeInteger GCD = 1;
            for (LargeInteger i = 1; i < max / 2; i++)
                if (a % i == 0 && b % i == 0)
                    GCD = i;
            return GCD;
        }
        public static LargeInteger Invert(LargeInteger l) => 1 / l;
        public static LargeInteger LeastCommonMultiple(LargeInteger a, LargeInteger b) => a * b / GreatestCommonDivisor(a, b);
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
            if (str[0] != 45) // If it's not a number character
            {
                str = str.Remove(0, 1);
                result.Sign = false;
            }
            if (str.Length > 0)
            {
                for (int i = 0; i < str.Length; i++)
                    if (str[i] < 48 || str[i] > 57) // If it's not a number character
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
            else throw new ElevateZeroToThePowerOfZeroException("Cannot perform the operation 0^0.");
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
        public static LargeInteger Root(LargeInteger b, LargeInteger rootClass)
        {
            int digCount = GetDecimalDigitCount(b);
            int maxSqrtCount = digCount / 2 + 1;
            int minSqrtCount = Math.Max((digCount / 2 - 1), 1);
            LargeInteger start = Power(10, (minSqrtCount - 1));
            LargeInteger end = Power(10, maxSqrtCount) - 1;
            LargeInteger middle = (start + end) / 2;
            LargeInteger power = 0;
            LargeInteger lastPower = 0;
            while ((power = Power(middle, rootClass)) != b && power != lastPower)
            {
                if (power < b)
                    middle = (end + middle) / 2;
                else
                    middle = (start + middle) / 2;
                lastPower = power;
            }
            return middle;
        }
        public static LargeInteger SquareRoot(LargeInteger l)
        {
            int digCount = GetDecimalDigitCount(l);
            int maxSqrtCount = digCount / 2 + 1;
            int minSqrtCount = Math.Max((digCount / 2 - 1), 1);
            LargeInteger start = Power(10, (minSqrtCount - 1));
            LargeInteger end = Power(10, maxSqrtCount) - 1;
            LargeInteger middle = (start + end) / 2;
            LargeInteger sq = 0;
            LargeInteger lastSq = 0;
            while ((sq = Power(middle, 2)) != l && sq != lastSq)
            {
                if (sq < l)
                    middle = (end + middle) / 2;
                else
                    middle = (start + middle) / 2;
                lastSq = sq;
            }
            return middle;
        }
        #endregion
        #region Overrides
        public override string ToString()
        {
            string result = "";
            if (Sign == false) result = "-";
            LargeInteger currentIntPart = this;
            for (LargeInteger i = 1; (currentIntPart = this / i) > 0; i *= 10)
                result = (char)((currentIntPart % 10) + 48) + result;
            return result;
        }
        #endregion
    }
}