using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Variables
{
    /// <summary>Represents a variable with a real number value.</summary>
    public class RealVariable : RealNumericExpression, IVariable
    {
        /// <summary>The name of the variable.</summary>
        public string Name { get; }

        /// <summary>Initializes a new instance of the <seealso cref="RealVariable"/> class.</summary>
        public RealVariable(string name)
        {
            Name = name;
        }

        protected override bool LessThan(RealNumericExpression expression) => throw new Exception("Cannot compare two variables.");
        protected override bool GreaterThan(RealNumericExpression expression) => throw new Exception("Cannot compare two variables.");
        protected override bool LessThanOrEqualTo(RealNumericExpression expression) => throw new Exception("Cannot compare two variables.");
        protected override bool GreaterThanOrEqualTo(RealNumericExpression expression) => throw new Exception("Cannot compare two variables.");
        protected override bool EqualTo(RealNumericExpression expression) => throw new Exception("Cannot compare two variables.");
        protected override bool DifferentThan(RealNumericExpression expression) => throw new Exception("Cannot compare two variables.");
    }
}
