using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Exponential
{
    /// <summary>Represents the exponentation base n (n^x) operation.</summary>
    public class Exponentation : FunctionOperation
    {
        public Expression Base;

        public Exponentation(Expression b, Expression argument)
        {
            Base = b;
            Argument = argument;
        }
    }
}
