using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Logarithmic
{
    /// <summary>Represents the logarithm base n operation.</summary>
    public class Logn : FunctionOperation
    {
        /// <summary>The base of the logarithm.</summary>
        public Expression Base;

        /// <summary>Creates a new instance of the <see cref="Log"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public Logn(Expression b, Expression argument)
             : base(argument)
        {
            Base = b;
        }

        /// <summary>Differentiates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when differentiating.</param>
        public override Expression Differentiate(Expression expression) => (new Ln(Argument) / new Ln(Base)).Differentiate(expression);
    }
}
