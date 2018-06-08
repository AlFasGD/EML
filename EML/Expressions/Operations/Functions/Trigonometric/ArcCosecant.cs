using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the inverse cosecant (arccsc) operation.</summary>
    public class ArcCosecant : FunctionOperation
    {
        public ArcCosecant(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
