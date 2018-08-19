using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the hyperbolic cosecant (csch) operation.</summary>
    public class Cosecanth : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="Cosecanth"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public Cosecanth(Expression argument) : base(argument) { }
    }
}
