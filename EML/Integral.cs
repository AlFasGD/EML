using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.NumericTypes;
using EML.Sets;
using EML.Tools;
using EML.Exceptions;

namespace EML
{
    /// <summary>Represents a general integral.</summary>
    public class Integral : Operation
    {
        /// <summary>The function of the integral.</summary>
        public Function Function;
        /// <summary>The variable to take into account while performing the integration.</summary>
        public string VariableName;

        /// <summary>Creates a new instance of <seealso cref="DefiniteIntegral"/>.</summary>
        /// <param name="function">The function of the integral.</param>
        /// <param name="variableName">The variable to take into account while performing the integration.</param>
        public Integral(Function function, string variableName)
        {
            Function = function;
            VariableName = variableName;
        }
    }
}