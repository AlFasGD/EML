using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Advanced
{
    /// <summary>Represents a summation (Σ) operation.</summary>
    public class Summation : Operation
    {
        /// <summary>The name of the variable used in the summation.</summary>
        public string VariableName;
        /// <summary>The lower bound value of the variable.</summary>
        public Expression LowerBoundValue;
        /// <summary>The upper bound value of the variable.</summary>
        public Expression UpperBoundValue;
        /// <summary>The expression that will be evaluated for the calculation of the summation.</summary>
        public Expression InnerExpression;

        public Summation(string variableName, Expression lowerBoundValue, Expression upperBoundValue, Expression innerExpression)
        {
            VariableName = variableName;
            LowerBoundValue = lowerBoundValue;
            UpperBoundValue = upperBoundValue;
            InnerExpression = innerExpression;
        }
    }
}
