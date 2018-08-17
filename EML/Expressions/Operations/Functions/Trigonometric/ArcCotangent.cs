using EML.Expressions.NumberExpressions;
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
        public ArcCotangent(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
