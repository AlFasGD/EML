using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.Expressions;

namespace EML.Expressions.Operations.Integrals
{
    /// <summary>Represents a definite integral.</summary>
    public class DefiniteIntegral : Integral
    {
        /// <summary>The start of the definite integral.</summary>
        public IRealNumericExpression Start;
        /// <summary>The end of the definite integral.</summary>
        public IRealNumericExpression End;

        /// <summary>Creates a new instance of <seealso cref="DefiniteIntegral"/>.</summary>
        /// <param name="start">The start of the definite integral.</param>
        /// <param name="end">The end of the definite integral.</param>
        /// <param name="function">The function of the definite integral.</param>
        /// <param name="variableName">The variable to take into account while performing the integration.</param>
        public DefiniteIntegral(IRealNumericExpression start, IRealNumericExpression end, Function function, string variableName)
            : base(function, variableName)
        {
            Start = start;
            End = end;
        }
    }
}