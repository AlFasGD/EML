using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations
{
    public class Exponentation : Operation
    {
        public Expression Base;
        public Expression Exponent;

        public Exponentation(Expression b, Expression exponent)
        {
            Base = b;
            Exponent = exponent;
        }
    }
}
