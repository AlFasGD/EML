using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the sine (sin) operation.</summary>
    public class Sine : FunctionOperation
    {
        public Sine(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
