using EML.Expressions.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Logarithmic
{
    /// <summary>Represents the log (logarithm base 10) operation.</summary>
    public class Log : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="Log"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public Log(Expression argument) : base(argument) { }

        /// <summary>Differentiates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when differentiating.</param>
        public override Expression Differentiate(Expression expression) => (new Ln(Argument) / new Ln(new RealConstant(10))).Differentiate(expression);
    }
}
