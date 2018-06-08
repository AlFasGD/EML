using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Basic
{
    /// <summary>Represents a division operation.</summary>
    public class Division : Operation
    {
        public Expression Left;
        public Expression Right;

        public Division(Expression left, Expression right)
        {
            Left = left;
            Right = right;
        }
    }
}
