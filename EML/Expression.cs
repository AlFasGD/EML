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
        Operation[] Operations { get; set; }

        /// <summary>Initializes a new instance of the <seealso cref="Expression"/> class.</summary>
        public Expression(LargeDecimal[] literals, Operation[] operations)
        {
            Literals = literals;
            Operations = operations;
        }
    }
}
