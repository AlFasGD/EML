using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Hyperbolic
{
    /// <summary>Represents the inverse hyperbolic cosine (arccosh) operation.</summary>
    public class ArcCosineh : FunctionOperation
    {
        public ArcCosineh(NumberExpression argument)
        {
            Argument = argument;
        }
    }
}
