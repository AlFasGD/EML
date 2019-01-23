using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the inverse sine (arcsin) operation.</summary>
    public class ArcSine : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="ArcSine"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public ArcSine(Expression argument) : base(argument) { }
    }
}
