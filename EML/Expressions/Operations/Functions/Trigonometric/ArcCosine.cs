using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the inverse cosine (arccos) operation.</summary>
    public class ArcCosine : FunctionOperation
    {
        public ArcCosine(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
