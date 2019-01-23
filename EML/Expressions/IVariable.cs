using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions
{
    /// <summary>Represents a variable.</summary>
    public interface IVariable
    {
        /// <summary>The name of the variable.</summary>
        string Name { get; }
    }
}
