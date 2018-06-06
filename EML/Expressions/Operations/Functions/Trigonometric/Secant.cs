using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the secant (sec) operation.</summary>
    public class Secant : FunctionOperation
    {
        public Secant(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
