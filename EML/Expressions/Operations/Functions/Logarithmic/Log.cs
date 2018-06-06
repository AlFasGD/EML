using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Logarithmic
{
    /// <summary>Represents the log (logarithm base 10) operation.</summary>
    public class Log : FunctionOperation
    {
        public Log(Expression argument)
        {
            Argument = argument;
        }
    }
}
