using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the inverse tangent (arctan) operation.</summary>
    public class ArcTangent : FunctionOperation
    {
        public ArcTangent(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
