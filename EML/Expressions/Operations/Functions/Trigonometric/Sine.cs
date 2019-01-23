using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the sine (sin) operation.</summary>
    public class Sine : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="Sine"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public Sine(Expression argument) : base(argument) { }

        /// <summary>Differentiates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when differentiating.</param>
        public override Expression Differentiate(Expression expression) => Argument.Differentiate(expression) * new Sine(Argument as NumberExpression) * new RealNumber(-1);
        // TODO: Change when unary negation operator is implemented
    }
}
