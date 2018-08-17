using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the inverse hyperbolic cotangent (arccoth) operation.</summary>
    public class ArcCotangenth : FunctionOperation
    {
        public ArcCotangenth(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
