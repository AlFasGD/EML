using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the inverse hyperbolic cosine (arccosh) operation.</summary>
    public class ArcCosineh : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="ArcCosineh"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public ArcCosineh(Expression argument) : base(argument) { }
    }
}
