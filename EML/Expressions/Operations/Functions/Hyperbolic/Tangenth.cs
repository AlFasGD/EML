using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the hyperbolic tangent (tanh) operation.</summary>
    public class Tangenth : FunctionOperation
    {
        public Tangenth(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
