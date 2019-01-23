using EML.NumericTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Constants
{
    /// <summary>Represents a real number constant.</summary>
    public sealed class RealConstant : Constant
    {
        /// <summary>The value of the real number constant.</summary>
        public LargeDecimal Value { get; }

        /// <summary>Initializes a new instance of the <seealso cref="RealConstant"/> class.<</summary>
        /// <param name="value">The value of the <seealso cref="RealConstant"/>.</param>
        public RealConstant(LargeDecimal value) : this(null, value) { }
        /// <summary>Initializes a new instance of the <seealso cref="RealConstant"/> class.<</summary>
        /// <param name="value">The value of the <seealso cref="RealConstant"/>.</param>
        public RealConstant(string name, LargeDecimal value)
            : base(name)
        {
            Value = value;
        }
    }
}
