using EML.Expressions.Constants;
using EML.Expressions.Operations.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the cosecant (csc) operation.</summary>
    public class Cosecant : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="Cosecant"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public Cosecant(Expression argument) : base(argument) { }

        /// <summary>Differentiates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when differentiating.</param>
        public override Expression Differentiate(Expression expression) => Argument.Differentiate(expression) * new Cosine(Argument as NumericExpression) / new Exponentation(new Sine(Argument as NumericExpression), new RealConstant(2)) * new RealConstant(-1);
    }
}
