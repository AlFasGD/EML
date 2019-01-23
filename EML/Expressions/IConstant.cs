using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions
{
    /// <summary>Represents a constant.</summary>
    public interface IConstant
    {
        /// <summary>The name of the constant.</summary>
        string Name { get; }
    }
}
