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
        public Expression Expression { get; set; }
        public SetExpression ExpressionDomain { get; set; }
        
        public NumberExpression(Expression expression, SetExpression expressionDomain)
        {
            Expression = expression;
            ExpressionDomain = expressionDomain;
        }

        // TODO: Find a way to implement comparison
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