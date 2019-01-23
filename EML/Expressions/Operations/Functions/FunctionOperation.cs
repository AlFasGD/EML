using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions
{
    /// <summary>Represents a predefined mathematical function.</summary>
    public abstract class FunctionOperation : Operation
    {
        /// <summary>The argument of the function.</summary>
        public Expression Argument;

        public FunctionOperation(Expression argument)
        {
            Argument = argument;
        }
    }
}
