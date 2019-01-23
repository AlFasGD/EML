using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions
{
    /// <summary>Represents a real numeric expression.</summary>
    public abstract class RealNumericExpression : NumericExpression
    {
        public static bool operator >(RealNumericExpression left, RealNumericExpression right) => left.GreaterThan(right);
        public static bool operator >=(RealNumericExpression left, RealNumericExpression right) => left.GreaterThanOrEqualTo(right);
        public static bool operator ==(RealNumericExpression left, RealNumericExpression right) => left.EqualTo(right);
        public static bool operator <=(RealNumericExpression left, RealNumericExpression right) => left.LessThanOrEqualTo(right);
        public static bool operator <(RealNumericExpression left, RealNumericExpression right) => left.LessThan(right);
        public static bool operator !=(RealNumericExpression left, RealNumericExpression right) => left.DifferentThan(right);

        protected abstract bool GreaterThan(RealNumericExpression expression);
        protected abstract bool GreaterThanOrEqualTo(RealNumericExpression expression);
        protected abstract bool EqualTo(RealNumericExpression expression);
        protected abstract bool LessThanOrEqualTo(RealNumericExpression expression);
        protected abstract bool LessThan(RealNumericExpression expression);
        protected abstract bool DifferentThan(RealNumericExpression expression);
    }
}
