using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the hyperbolic secant (sech) operation.</summary>
    public class Secanth : FunctionOperation
    {
        public Secanth(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
