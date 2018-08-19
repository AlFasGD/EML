using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.General
{
    /// <summary>Represents the absolute value operation.</summary>
    public class Absolute : FunctionOperation
    {
        public Absolute(Expression argument)
        {
            Argument = argument;
        }
    }
}
