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
using EML.Expressions.Operations.Basic;

namespace EML.Expressions
{
    public abstract class Expression
    {
        public static Addition operator +(Expression left, Expression right) => new Addition(left, right);
        public static Subtraction operator -(Expression left, Expression right) => new Subtraction(left, right);
        public static Multiplication operator *(Expression left, Expression right) => new Multiplication(left, right);
        public static Division operator /(Expression left, Expression right) => new Division(left, right);

        /// <summary>Differentiates the current expression.</summary>
        public virtual Expression Differentiate() => throw new InvalidOperationException("Cannot differentiate the current expression.");

        /// <summary>Integrates the current expression.</summary>
        public virtual Expression Integrate() => throw new InvalidOperationException("Cannot integrate the current expression.");
    }
}