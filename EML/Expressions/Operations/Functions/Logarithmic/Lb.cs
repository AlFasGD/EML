using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Logarithmic
{
    /// <summary>Represents the lb (logarithm base 2) operation.</summary>
    public class Lb : FunctionOperation
    {
        public Lb(Expression argument)
        {
            Argument = argument;
        }
    }
}
