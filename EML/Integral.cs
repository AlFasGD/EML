using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    /// <summary>Represents an integral.</summary>
    public class Integral : Operation 
    {
        /// <summary>The start of the integral.</summary>
        public RealNumberExpression start;
        /// <summary>The end of the integral.</summary>
        public RealNumberExpression end;
        /// <summary>The end of the integral.</summary>
        public Function function;
        /// <summary>The variable to take into account while performing the integration.</summary>
        public string variableName;
    }
}
