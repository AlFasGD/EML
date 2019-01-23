using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the inverse cotangent (arccot) operation.</summary>
    public class ArcCotangent : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="ArcCotangent"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public ArcCotangent(Expression argument) : base(argument) { }
    }
}
