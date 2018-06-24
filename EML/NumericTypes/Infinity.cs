using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.Tools;
using EML.Exceptions;
using EML.Tools.Enumerations;
using static EML.Tools.Enumerations.SignFunctions;

namespace EML.NumericTypes
{
    public class Infinity
    {
        public Sign Sign { get; set; }
        // public Limit Formula { get; set; }

        public Infinity(Sign sign)
        {
            if (sign != Sign.Neutral)
                Sign = sign;
            else
                throw new ArgumentException("Infinity cannot be zero.");
        }

        public static Infinity operator +(Infinity left, Infinity right)
        {
            if (left.Sign == right.Sign)
                return left;
            else
                throw new InvalidOperationException("Cannot add infinities with different signs.");
        }
        public static Infinity operator -(Infinity left, Infinity right) => left + (-right);
        public static Infinity operator *(Infinity left, Infinity right) => new Infinity(Multiply(left.Sign, right.Sign));

        public static Infinity operator +(LargeInteger left, Infinity right) => right;
        public static Infinity operator +(Infinity left, LargeInteger right) => left;
        public static Infinity operator -(LargeInteger left, Infinity right) => left + (-right);
        public static Infinity operator -(Infinity left, LargeInteger right) => left + (-right);
        public static Infinity operator *(LargeInteger left, Infinity right) => new Infinity(Multiply(left.Sign, right.Sign));
        public static Infinity operator *(Infinity left, LargeInteger right) => right != 0 ? new Infinity(Multiply(left.Sign, right.Sign)) : throw new ArithmeticException("Cannot multiply infinity and zero.");
        public static Infinity operator /(LargeInteger left, Infinity right) => new Infinity(Multiply(left.Sign, right.Sign));
        public static Infinity operator /(Infinity left, LargeInteger right) => new Infinity(Multiply(left.Sign, right.Sign));

        public static Infinity operator -(Infinity i) => new Infinity(Invert(i.Sign));
    }
}
