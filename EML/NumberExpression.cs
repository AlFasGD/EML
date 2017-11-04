using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    public class NumberExpression : Expression
    {
        Expression A { get; set; }
        Expression B { get; set; }
        Expression C { get; set; }
        Expression D { get; set; }
        SpecialNumberSet Set { get; set; }
    }
}
