using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Logarithmic
{
    /// <summary>Represents the lb (logarithm base 2) operation.</summary>
    public class Lb : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="Lb"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public Lb(Expression argument) : base(argument) { }

        /// <summary>Differentiates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when differentiating.</param>
        public override Expression Differentiate(Expression expression) => (new Ln(Argument) / new Ln(new RealNumber(2))).Differentiate(expression);
    }
}
