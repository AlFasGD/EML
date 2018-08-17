using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the hyperbolic cosecant (csch) operation.</summary>
    public class Cosecanth : FunctionOperation
    {
        public Cosecanth(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
