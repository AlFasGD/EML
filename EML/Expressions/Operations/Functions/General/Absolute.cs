using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.General
{
    /// <summary>Represents the absolute value operation.</summary>
    public class Absolute : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="Absolute"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public Absolute(Expression argument) : base(argument) { }
    }
}
