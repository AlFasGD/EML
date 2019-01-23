using EML.NumericTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Constants
{
    /// <summary>Represents a real number constant.</summary>
    public sealed class RealConstant : RealNumericExpression, IConstant
    {
        /// <summary>The name of the constant.</summary>
        public string Name { get; set; }
        /// <summary>The value of the real number constant.</summary>
        public LargeDecimal Value { get; }

        /// <summary>Initializes a new instance of the <seealso cref="RealConstant"/> class.</summary>
        /// <param name="value">The value of the <seealso cref="RealConstant"/>.</param>
        public RealConstant(LargeDecimal value) : this(null, value) { }
        /// <summary>Initializes a new instance of the <seealso cref="RealConstant"/> class.</summary>
        /// <param name="value">The value of the <seealso cref="RealConstant"/>.</param>
        public RealConstant(string name, LargeDecimal value)
        {
            Name = name;
            Value = value;
        }

        public static bool operator <(RealConstant left, RealConstant right) => left.Value < right.Value;
        public static bool operator >(RealConstant left, RealConstant right) => left.Value > right.Value;
        public static bool operator >=(RealConstant left, RealConstant right) => left.Value >= right.Value;
        public static bool operator <=(RealConstant left, RealConstant right) => left.Value <= right.Value;
        public static bool operator ==(RealConstant left, RealConstant right) => left.Value == right.Value;
        public static bool operator !=(RealConstant left, RealConstant right) => left.Value != right.Value;

        protected override bool LessThan(RealNumericExpression expression) => Value < (expression as RealConstant).Value;
        protected override bool GreaterThan(RealNumericExpression expression) => Value > (expression as RealConstant).Value;
        protected override bool LessThanOrEqualTo(RealNumericExpression expression) => Value <= (expression as RealConstant).Value;
        protected override bool GreaterThanOrEqualTo(RealNumericExpression expression) => Value >= (expression as RealConstant).Value;
        protected override bool EqualTo(RealNumericExpression expression) => Value == (expression as RealConstant).Value;
        protected override bool DifferentThan(RealNumericExpression expression) => Value != (expression as RealConstant).Value;
    }
}
