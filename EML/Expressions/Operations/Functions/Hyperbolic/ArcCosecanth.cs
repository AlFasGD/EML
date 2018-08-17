using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the inverse hyperbolic cosecant (arccsch) operation.</summary>
    public class ArcCosecanth : FunctionOperation
    {
        public ArcCosecanth(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
