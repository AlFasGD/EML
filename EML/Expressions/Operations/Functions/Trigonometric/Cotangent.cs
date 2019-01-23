﻿using EML.Expressions.Constants;
using EML.Expressions.Operations.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions.Operations.Functions.Trigonometric
{
    /// <summary>Represents the cotangent (cot) operation.</summary>
    public class Cotangent : FunctionOperation
    {
        /// <summary>Creates a new instance of the <see cref="Cotangent"/> class.</summary>
        /// <param name="argument">The argument of the function.</param>
        public Cotangent(Expression argument) : base(argument) { }

        /// <summary>Differentiates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when differentiating.</param>
        public override Expression Differentiate(Expression expression) => Argument.Differentiate(expression) / new Exponentation(new Sine(Argument as NumericExpression), new RealConstant(2)) * new RealConstant(-1);
        // TODO: Change when unary negation operator is implemented
    }
}
