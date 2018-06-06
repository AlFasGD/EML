using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations
{
    public class Addition : Operation
    {
        public Expression Left;
        public Expression Right;
        
        public Addition(Expression left, Expression right)
        {
            Left = left;
            Right = right;
        }
    }
}