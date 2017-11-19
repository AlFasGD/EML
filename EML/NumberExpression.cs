using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    public class NumberExpression : Expression
    {
        Expression[] Expressions { get; set; }
        SpecialNumberSet ExpressionDomain { get; set; }


    }
}
