using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Advanced
{
    /// <summary>Represents a conditional summation (Σ) operation that performs a summation with all values that satisfy the condition.</summary>
    public class ConditionalSummation : Operation
    {
        /// <summary>The name of the variable used in the summation.</summary>
        public string VariableName;
        /// <summary>The condition for performing the summation.</summary>
        public Expression Condition;
        /// <summary>The expression that will be evaluated for the calculation of the summation.</summary>
        public Expression InnerExpression;

        public ConditionalSummation(string variableName, Expression condition, Expression innerExpression)
        {
            VariableName = variableName;
            Condition = condition;
            InnerExpression = innerExpression;
        }
    }
}
