using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the hyperbolic sine (sinh) operation.</summary>
    public class Sineh : FunctionOperation
    {
        public Sineh(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
