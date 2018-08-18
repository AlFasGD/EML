using EML.NumericTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.NumberExpressions
{
    /// <summary>Represents a real number.</summary>
    public class RealNumber : Expression
    {
        public LargeDecimal Value { get; set; }

        /// <summary>Initializes a new instance of the <seealso cref="RealNumberExpression"/> class.</summary>
        public RealNumber(LargeDecimal value)
        {
            Value = value;
        }

        #region Implicit Conversions
        public static implicit operator RealNumber(byte value) => new RealNumber(value);
        public static implicit operator RealNumber(short value) => new RealNumber(value);
        public static implicit operator RealNumber(int value) => new RealNumber(value);
        public static implicit operator RealNumber(long value) => new RealNumber(value);
        public static implicit operator RealNumber(sbyte value) => new RealNumber(value);
        public static implicit operator RealNumber(ushort value) => new RealNumber(value);
        public static implicit operator RealNumber(uint value) => new RealNumber(value);
        public static implicit operator RealNumber(ulong value) => new RealNumber(value);
        public static implicit operator RealNumber(LargeInteger value) => new RealNumber(value);
        public static implicit operator RealNumber(LargeDecimal value) => new RealNumber(value);
        #endregion

        /// <summary>Differentiates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when differentiating.</param>
        public override Expression Differentiate(Expression expression) => new RealNumber(0);
    }
}