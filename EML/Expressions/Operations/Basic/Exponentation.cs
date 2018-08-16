﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Basic
{
    /// <summary>Represents an exponentation operation.</summary>
    public class Exponentation : Operation
    {
        public Expression Base;
        public Expression Exponent;

        public Exponentation(Expression b, Expression exponent)
        {
            Base = b;
            Exponent = exponent;
        }
		
		/// <summary>Differentiates the current expression.</summary>
		public override Operation Differentiate()
		{
			if (Base is e)
				return Exponent.Differentiate() * new Exponentation(Base, Exponent);
			return new Exponentation(new e(), Exponent * new Ln(Base)).Differentiate();
		}
    }
}