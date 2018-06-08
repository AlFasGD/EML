using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Sets
{
    /// <summary>Represents a number set.</summary>
    public class NumberSet
    {
        public SetOperation Operation;

        /// <summary>Initializes a new instance of the <seealso cref="NumberSet"/> class.</summary>
        public NumberSet(SetOperation operation)
        {
            Operation = operation;
        }
    }
}
