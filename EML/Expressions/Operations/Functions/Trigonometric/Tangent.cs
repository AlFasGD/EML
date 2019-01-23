using EML.Expressions.Constants;
using EML.Expressions.Operations.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the tangent (tan) operation.</summary>
    public class Tangent : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="Tangent"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public Tangent(Expression argument) : base(argument) { }

        /// <summary>Differentiates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when differentiating.</param>
        public override Expression Differentiate(Expression expression) => Argument.Differentiate(expression) / new Exponentation(new Cosine(Argument as NumericExpression), new RealConstant(2));
    }
}
