﻿using System;
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
        
        public NumberExpression(Expression[] expressions, SpecialNumberSet expressionDomain, LargeDecimal[] literals, OperationType[] operations)
            : base(literals, operations)
        {
            Expressions = expressions;
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