using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    public class Expression
    {
        LargeDecimal[] Literals { get; set; }
        OperationType[] Operations { get; set; }

        /// <summary>Initializes a new instance of the <seealso cref="Expression"/> class.</summary>
        public Expression(LargeDecimal[] literals, OperationType[] operations)
        {
            Literals = literals;
            Operations = operations;
        }
    }
}
