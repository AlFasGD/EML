using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the inverse sine (arcsin) operation.</summary>
    public class ArcSine : FunctionOperation
    {
        public ArcSine(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
