using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the tangent (tan) operation.</summary>
    public class Tangent : FunctionOperation
    {
        public Tangent(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
