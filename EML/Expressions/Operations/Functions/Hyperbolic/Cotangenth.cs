using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the hyperbolic cotangent (coth) operation.</summary>
    public class Cotangenth : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="Cotangenth"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public Cotangenth(Expression argument) : base(argument) { }
    }
}
