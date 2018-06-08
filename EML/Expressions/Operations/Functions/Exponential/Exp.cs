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
    }
}
