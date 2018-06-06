using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Logarithmic
{
    /// <summary>Represents the ln (logarithm base e) operation.</summary>
    public class Ln : FunctionOperation
    {
        public Ln(Expression argument)
        {
            Argument = argument;
        }
    }
}
