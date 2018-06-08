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
        public ArcSecant(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
