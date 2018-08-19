using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the inverse hyperbolic tangent (arctanh) operation.</summary>
    public class ArcTangenth : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="ArcTangenth"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public ArcTangenth(Expression argument) : base(argument) { }
    }
}
