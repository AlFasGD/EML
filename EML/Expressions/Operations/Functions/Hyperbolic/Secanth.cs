using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the hyperbolic secant (sech) operation.</summary>
    public class Secanth : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="Secanth"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public Secanth(Expression argument) : base(argument) { }
    }
}
