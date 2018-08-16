using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.Expressions.Operations;

namespace EML.Expressions
{
    /// <summary>Represents an operation.</summary>
    public abstract class Operation : Expression
    {
		/// <summary>Differentiates the current expression.</summary>
		public virtual Operation Differentiate() => null;
		
		/// <summary>Integrates the current expression.</summary>
		public virtual Operation Integrate() => null;
    }
}