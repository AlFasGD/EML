using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the inverse cosine (arccos) operation.</summary>
    public class ArcCosine : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="ArcCosine"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public ArcCosine(Expression argument) : base(argument) { }
    }
}
