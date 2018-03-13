using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    public class RealNumberExpression : Expression
    {
        public string Name { get; set; }

        /// <summary>Initializes a new instance of the <seealso cref="RealNumberExpression"/> class.</summary>
        public RealNumberExpression(string name, LargeDecimal[] literals, Operation[] operations)
            : base(literals, operations)
        {
            Name = name;
        }
    }
}