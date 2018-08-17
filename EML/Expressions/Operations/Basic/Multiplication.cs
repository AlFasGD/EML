using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Basic
{
    /// <summary>Represents a multiplication operation.</summary>
    public class Multiplication : Operation
    {
        public Expression Left;
        public Expression Right;

        public Multiplication(Expression left, Expression right)
        {
            Left = left;
            Right = right;
        }
		
		/// <summary>Differentiates the current expression.</summary>
		public override Expression Differentiate() => Left.Differentiate() * Right + Left * Right.Differentiate();
    }
}