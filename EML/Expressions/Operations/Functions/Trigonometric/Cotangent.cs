using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the cotangent (cot) operation.</summary>
    public class Cotangent : FunctionOperation
    {
        public Cotangent(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
