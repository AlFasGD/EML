using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Basic
{
    /// <summary>Represents an addition operation.</summary>
    public class Addition : Operation
    {
        public Expression Left;
        public Expression Right;
        
        public Addition(Expression left, Expression right)
        {
            Left = left;
            Right = right;
        }

        /// <summary>Differentiates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when differentiating.</param>
        public override Expression Differentiate(Expression expression) => Left.Differentiate(expression) + Right.Differentiate(expression);

        /// <summary>Integrates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when integrating.</param>
        public override Expression Integrate(Expression expression) => Left.Integrate(expression) + Right.Integrate(expression);
    }
}