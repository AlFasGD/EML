using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the inverse hyperbolic tangent (arctanh) operation.</summary>
    public class ArcTangenth : FunctionOperation
    {
        public ArcTangenth(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
