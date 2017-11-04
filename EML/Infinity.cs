using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    public class Infinity
    {
        public bool Sign { get; set; }
        // public int RelativeSize { get; set; }

        public Infinity(bool sign)
        {
            Sign = sign;
        }

        public static Infinity operator +(Infinity left, Infinity right)
        {
            if (left.Sign == right.Sign)
                return left;
            else
                throw new InvalidOperationException("Cannot add infinities with different signs.");
        }
        public static Infinity operator -(Infinity left, Infinity right) => left + (-right);
        public static Infinity operator *(Infinity left, Infinity right) => new Infinity(left.Sign == right.Sign);

        public static Infinity operator +(LargeInteger left, Infinity right) => right;
        public static Infinity operator +(Infinity left, LargeInteger right) => left;
        public static Infinity operator -(LargeInteger left, Infinity right) => left + (-right);
        public static Infinity operator -(Infinity left, LargeInteger right) => left + (-right);
        public static Infinity operator *(LargeInteger left, Infinity right) => new Infinity(left.Sign == right.Sign);
        public static Infinity operator *(Infinity left, LargeInteger right) => new Infinity(left.Sign == right.Sign);
        public static Infinity operator /(LargeInteger left, Infinity right) => new Infinity(left.Sign == right.Sign);
        public static Infinity operator /(Infinity left, LargeInteger right) => new Infinity(left.Sign == right.Sign);

        public static Infinity operator -(Infinity i) => new Infinity(!i.Sign);
    }
}
