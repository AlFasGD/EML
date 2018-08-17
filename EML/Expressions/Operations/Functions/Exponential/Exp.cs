using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Exponential
{
    /// <summary>Represents the exponentation base e (e^x) operation.</summary>
    public class Exp : FunctionOperation
    {
        public Exp(Expression argument)
        {
            Argument = argument;
        }

        /// <summary>Differentiates the current expression.</summary>
        public override Expression Differentiate() => Argument.Differentiate() + new Exp(Argument);

        /// <summary>Integrates the current expression.</summary>
        public override Expression Integrate() => Argument.Integrate() + new Exp(Argument);
    }
}
