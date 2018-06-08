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
        public ArcSecanth(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
