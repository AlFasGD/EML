using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Logarithmic
{
    /// <summary>Represents the logarithm base n operation.</summary>
    public class Logn : FunctionOperation
    {
        public Expression Base;

        public Logn(Expression b, Expression argument)
        {
            Base = b;
            Argument = argument;
        }
    }
}
