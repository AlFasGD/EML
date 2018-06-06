using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.NumericTypes;
using EML.Sets;
using EML.Tools;
using EML.Exceptions;
using EML.Expressions.Operations;

namespace EML.Expressions
{
    public class RealNumberExpression : Expression
    {
        public string Name { get; set; }

        /// <summary>Initializes a new instance of the <seealso cref="RealNumberExpression"/> class.</summary>
        public RealNumberExpression(string name, Operation operation)
            : base(operation)
        {
            Name = name;
        }

        #region Operators
        // Only made for the compiler to work
        public static RealNumberExpression operator +(RealNumberExpression left, RealNumberExpression right)
        {
            return new RealNumberExpression($"{left.Name} + {right.Name}", (left as Expression) + (right as Expression));
        }
        public static RealNumberExpression operator -(RealNumberExpression left, RealNumberExpression right)
        {
            return new RealNumberExpression($"{left.Name} + {right.Name}", (left as Expression) - (right as Expression));
        }
        public static RealNumberExpression operator *(RealNumberExpression left, RealNumberExpression right)
        {
            return new RealNumberExpression($"{left.Name} + {right.Name}", (left as Expression) * (right as Expression));
        }
        public static RealNumberExpression operator /(RealNumberExpression left, RealNumberExpression right)
        {
            return new RealNumberExpression($"{left.Name} + {right.Name}", (left as Expression) / (right as Expression));
        }
        #endregion
        #region Operations
        public static RealNumberExpression Power(RealNumberExpression b, RealNumberExpression power)
        {
            return new RealNumberExpression(b.Name, new Exponentation(b, power));
        }
        #endregion
        #region Overrides
        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}