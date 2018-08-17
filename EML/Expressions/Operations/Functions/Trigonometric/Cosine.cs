using EML.Expressions.NumberExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the cosine (cos) operation.</summary>
    public class Cosine : FunctionOperation
    {
        public Cosine(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
