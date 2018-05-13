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
    public class RealNumberExpression : Expression
    {
        public string Name { get; set; }

        /// <summary>Initializes a new instance of the <seealso cref="RealNumberExpression"/> class.</summary>
        public RealNumberExpression(string name, LargeDecimal[] literals, OperationType[] operations)
            : base(literals, operations)
        {
            Name = name;
        }

        #region Operators
        // Only made for the compiler to work
        public static RealNumberExpression operator +(RealNumberExpression left, RealNumberExpression right)
        {
            return new RealNumberExpression(left.Name + right.Name, new LargeDecimal[0], new OperationType[0]);
        }
        public static RealNumberExpression operator -(RealNumberExpression left, RealNumberExpression right)
        {
            return new RealNumberExpression(left.Name + right.Name, new LargeDecimal[0], new OperationType[0]);
        }
        public static RealNumberExpression operator *(RealNumberExpression left, RealNumberExpression right)
        {
            return new RealNumberExpression(left.Name + right.Name, new LargeDecimal[0], new OperationType[0]);
        }
        public static RealNumberExpression operator /(RealNumberExpression left, RealNumberExpression right)
        {
            return new RealNumberExpression(left.Name + right.Name, new LargeDecimal[0], new OperationType[0]);
        }
        #endregion
        #region Operations
        public static RealNumberExpression Power(RealNumberExpression b, RealNumberExpression power)
        {
            return new RealNumberExpression(b.Name, new LargeDecimal[0], new OperationType[0]);
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