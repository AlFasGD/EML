using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the inverse hyperbolic sine (arcsinh) operation.</summary>
    public class ArcSineh : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="ArcSineh"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public ArcSineh(Expression argument) : base(argument) { }
    }
}
