using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the inverse cosecant (arccsc) operation.</summary>
    public class ArcCosecant : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="ArcCosecant"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public ArcCosecant(Expression argument) : base(argument) { }
    }
}
