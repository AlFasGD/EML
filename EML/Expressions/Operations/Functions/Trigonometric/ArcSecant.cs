using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the inverse secant (arcsec) operation.</summary>
    public class ArcSecant : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="ArcSecant"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public ArcSecant(Expression argument) : base(argument) { }
    }
}
