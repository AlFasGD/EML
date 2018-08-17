using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.NumericTypes;
using EML.Sets;
using EML.Tools;
using EML.Exceptions;
using EML.Sets.SpecialNumberSets;

namespace EML.Expressions.NumberExpressions
{
    public class NumberExpression : Expression
    {
        public Operation Operation { get; set; }
        public SetExpression ExpressionDomain { get; set; }
        
        public NumberExpression(Operation operation, SetExpression expressionDomain)
        {
            Operation = operation;
            ExpressionDomain = expressionDomain;
        }

        // Only needed for compilation
        public static bool operator ==(NumberExpression left, NumberExpression right)
        {
            return false;
        }
        public static bool operator !=(NumberExpression left, NumberExpression right)
        {
            return false;
        }
        public static bool operator <(NumberExpression left, NumberExpression right)
        {
            return false;
        }
        public static bool operator >(NumberExpression left, NumberExpression right)
        {
            return false;
        }
        public static bool operator <=(NumberExpression left, NumberExpression right)
        {
            return false;
        }
        public static bool operator >=(NumberExpression left, NumberExpression right)
        {
            return false;
        }
    }
}