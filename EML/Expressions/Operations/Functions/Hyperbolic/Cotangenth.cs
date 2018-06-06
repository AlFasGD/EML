using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the hyperbolic cotangent (coth) operation.</summary>
    public class Cotangenth : FunctionOperation
    {
        public Cotangenth(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
