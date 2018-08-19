using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the inverse hyperbolic secant (arcsech) operation.</summary>
    public class ArcSecanth : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="ArcSecanth"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public ArcSecanth(Expression argument) : base(argument) { }
    }
}
