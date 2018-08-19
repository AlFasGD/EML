using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Exponential
{
    /// <summary>Represents the exponentation base e (e^x) operation.</summary>
    public class Exp : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="Exp"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public Exp(Expression argument) : base(argument) { }

        /// <summary>Differentiates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when differentiating.</param>
        public override Expression Differentiate(Expression expression) => Argument.Differentiate(expression) * new Exp(Argument);

        /// <summary>Integrates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when integrate.</param>
        public override Expression Integrate(Expression expression) => Argument.Integrate(expression) * new Exp(Argument);
    }
}
