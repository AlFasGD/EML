using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Sets
{
    public class NumberSet
    {
        public RealNumberInterval[] Intervals { get; set; }
        public SetOperation[] SetOperations { get; set; }

        /// <summary>Initializes a new instance of the <seealso cref="NumberSet"/> class.</summary>
        public NumberSet(RealNumberInterval[] intervals, SetOperation[] setOperations)
        {
            Intervals = intervals;
            SetOperations = setOperations;
        }
    }
}
