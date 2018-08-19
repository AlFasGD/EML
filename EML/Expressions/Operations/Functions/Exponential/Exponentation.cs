using EML.Expressions.Operations.Functions.Logarithmic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Exponential
{
    /// <summary>Represents the exponentation base n (n^x) operation.</summary>
    public class Exponentation : FunctionOperation
    {
        /// <summary>The base of the exponentation.</summary>
        public Expression Base;

        /// <summary>Creates a new instance of the <see cref="Exponentation"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public Exponentation(Expression b, Expression argument)
             : base(argument)
        {
            Base = b;
        }

        /// <summary>Differentiates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when differentiating.</param>
        public override Expression Differentiate(Expression expression) => new Exp(Argument * new Ln(Base)).Differentiate(expression);

        /// <summary>Integrates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when integrating.</param>
        public override Expression Integrate(Expression expression) => new Exp(Argument * new Ln(Base)).Integrate(expression);
    }
}
