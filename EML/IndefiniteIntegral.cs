using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    /// <summary>Represents an indefinite integral.</summary>
    public class IndefiniteIntegral : Integral
    {
        /// <summary>Creates a new instance of <seealso cref="IndefiniteIntegral"/>.</summary>
        /// <param name="function">The function of the indefinite integral.</param>
        /// <param name="variableName">The variable to take into account while performing the integration.</param>
        public IndefiniteIntegral(Function function, string variableName)
            : base(function, variableName)
        {

        }
    }
}