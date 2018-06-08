using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the inverse hyperbolic sine (arcsinh) operation.</summary>
    public class ArcSineh : FunctionOperation
    {
        public ArcSineh(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
