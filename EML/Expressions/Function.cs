using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.NumericTypes;
using EML.Sets;
using EML.Tools;
using EML.Exceptions;
using EML.Sets.Operations;

namespace EML.Expressions
{
    /// <summary>Represents a function.</summary>
    public class Function : Expression
    {
        /// <summary>The name of the function.</summary>
        public string Name;
        /// <summary>The function formula.</summary>
        public Expression Formula;
        /// <summary>The function's domain.</summary>
        public SetExpression Domain;
        /// <summary>The function's codomain.</summary>
        public SetExpression Codomain;
        /// <summary>The known values of the function.</summary>
        public Dictionary<Expression, Expression> KnownValues;

        /// <summary>Creates a new instance of <seealso cref="Function"/>.</summary>
        /// <param name="name">The name of the function.</param>
        /// <param name="domain">The function's domain.</param>
        /// <param name="codomain">The function's codomain.</param>
        /// <param name="knownValues">The known values of the function.</param>
        public Function(string name, SetExpression domain, SetExpression codomain, Dictionary<Expression, Expression> knownValues)
            : this(name, null, domain, codomain, knownValues) { }
        /// <summary>Creates a new instance of <seealso cref="Function"/>.</summary>
        /// <param name="name">The name of the function.</param>
        /// <param name="formula">The function formula.</param>
        /// <param name="domain">The function's domain.</param>
        /// <param name="codomain">The function's codomain.</param>
        public Function(string name, Expression formula, SetExpression domain, SetExpression codomain)
            : this(name, formula, domain, codomain, new Dictionary<Expression, Expression>()) { }
        /// <summary>Creates a new instance of <seealso cref="Function"/>.</summary>
        /// <param name="name">The name of the function.</param>
        /// <param name="formula">The function formula.</param>
        /// <param name="domain">The function's domain.</param>
        /// <param name="codomain">The function's codomain.</param>
        /// <param name="knownValues">The known values of the function.</param>
        public Function(string name, Expression formula, SetExpression domain, SetExpression codomain, Dictionary<Expression, Expression> knownValues)
        {
            Name = name;
            Formula = formula;
            Domain = domain;
            Codomain = codomain;
            KnownValues = knownValues;
        }

        public static Function operator +(Function left, Function right) => Operation(left, right, (leftValue, rightValue) => leftValue + rightValue, "+");
        public static Function operator -(Function left, Function right) => Operation(left, right, (leftValue, rightValue) => leftValue - rightValue, "-");
        public static Function operator *(Function left, Function right) => Operation(left, right, (leftValue, rightValue) => leftValue * rightValue, "*");
        public static Function operator /(Function left, Function right) => Operation(left, right, (leftValue, rightValue) => leftValue / rightValue, "/");

        private static Function Operation(Function left, Function right, Func<Expression, Expression, Operation> operation, string nameSeparator)
        {
            var domain = new Intersection(left.Domain, right.Domain);
            var codomain = new Union(left.Codomain, right.Codomain);
            var knownValues = new Dictionary<Expression, Expression>();
            foreach (var kvp in left.KnownValues)
                if (right.KnownValues.ContainsKey(kvp.Key))
                {
                    var leftValue = kvp.Value;
                    var rightValue = right.KnownValues[kvp.Key];
                    knownValues.Add(kvp.Key, operation.Invoke(leftValue, rightValue));
                }
            var formula = operation.Invoke(left.Formula, right.Formula) ?? null;
            return new Function($"{left.Name} {nameSeparator} {right.Name}", formula, domain, codomain, knownValues);
        }

        /// <summary>Differentiates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when differentiating.</param>
        public override Expression Differentiate(Expression expression)
        {
            if (Formula != null)
                return base.Differentiate(expression);
            return new Function($"{Name}'", Formula.Differentiate(expression), Domain, Codomain);
        }

        /// <summary>Integrates the current expression.</summary>
        /// <param name="expression">The expression that will be regarded when integrating.</param>
        public override Expression Integrate(Expression expression)
        {
            if (Formula != null)
                return base.Integrate(expression);
            return new Function($"{Name}'", Formula.Integrate(expression), Domain, Codomain);
        }
    }
}