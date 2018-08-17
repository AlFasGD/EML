﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Basic
{
    /// <summary>Represents a subtraction operation.</summary>
    public class Subtraction : Operation
    {
        public Expression Left;
        public Expression Right;

        public Subtraction(Expression left, Expression right)
        {
            Left = left;
            Right = right;
        }
		
		/// <summary>Differentiates the current expression.</summary>
		public override Expression Differentiate() => Left.Differentiate() - Right.Differentiate();
		
		/// <summary>Integrates the current expression.</summary>
		public override Expression Integrate() => Left.Integrate() - Right.Integrate();
    }
}