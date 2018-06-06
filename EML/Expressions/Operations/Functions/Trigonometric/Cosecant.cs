using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the cosecant (csc) operation.</summary>
    public class Cosecant : FunctionOperation
    {
        public Cosecant(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
