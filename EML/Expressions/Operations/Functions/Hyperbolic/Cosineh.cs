using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the hyperbolic cosine (cosh) operation.</summary>
    public class Cosineh : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="Cosineh"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public Cosineh(Expression argument) : base(argument) { }
    }
}
