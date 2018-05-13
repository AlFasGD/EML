using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.NumericTypes;
using EML.Sets;
using EML.Tools;
using EML.Exceptions;

namespace EML.Expressions
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
