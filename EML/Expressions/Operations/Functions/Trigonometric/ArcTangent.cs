using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the inverse tangent (arctan) operation.</summary>
    public class ArcTangent : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="ArcTangent"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public ArcTangent(Expression argument) : base(argument) { }
    }
}
