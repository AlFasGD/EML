using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Logarithmic
{
    /// <summary>Represents the ln (logarithm base e) operation.</summary>
    public class Ln : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="Ln"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public Ln(Expression argument) : base(argument) { }

        /// <summary>Differentiates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when differentiating.</param>
        public override Expression Differentiate(Expression expression) => Argument.Differentiate(expression) / Argument;
    }
}
