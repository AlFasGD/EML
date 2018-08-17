using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the hyperbolic cosine (cosh) operation.</summary>
    public class Cosineh : FunctionOperation
    {
        public Cosineh(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
