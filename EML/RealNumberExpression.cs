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
        public LargeDecimal[] Literals { get; set; }
        public Operation[] Operations { get; set; }

    }
}
