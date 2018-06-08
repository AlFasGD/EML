using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Advanced
{
    /// <summary>Represents a limit (lim) operation.</summary>
    public class Limit : Operation
    {
        /// <summary>The name of the variable that approaches the value.</summary>
        public string VariableName;
        /// <summary>The value the variable is approaching.</summary>
        public Expression ApproachingValue;
        /// <summary>The expression that will be evaluated for the calculation of the limit.</summary>
        public Expression InnerExpression;

        public Limit(string variableName, Expression approachingValue, Expression innerExpression)
        {
            VariableName = variableName;
            ApproachingValue = approachingValue;
            InnerExpression = innerExpression;
        }
    }
}
