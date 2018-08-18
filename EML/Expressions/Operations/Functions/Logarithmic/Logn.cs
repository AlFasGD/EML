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
        public Expression Base;

        public Logn(Expression b, Expression argument)
        {
            Base = b;
            Argument = argument;
        }

        /// <summary>Differentiates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when differentiating.</param>
        public override Expression Differentiate(Expression expression) => (new Ln(Argument) / new Ln(Base)).Differentiate(expression);
    }
}
