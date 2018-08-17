using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.NumericTypes;
using EML.Sets;
using EML.Tools;
using EML.Exceptions;
using EML.Expressions.NumberExpressions;
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
        public Dictionary<NumberExpression, NumberExpression> KnownValues;

        /// <summary>Creates a new instance of <seealso cref="Function"/>.</summary>
        /// <param name="name">The name of the function.</param>
        /// <param name="domain">The function's domain.</param>
        /// <param name="codomain">The function's codomain.</param>
        /// <param name="knownValues">The known values of the function.</param>
        public Function(string name, SetExpression domain, SetExpression codomain, Dictionary<NumberExpression, NumberExpression> knownValues)
        {
            Name = name;
            Formula = null;
            Domain = domain;
            Codomain = codomain;
            KnownValues = knownValues;
        }
        /// <summary>Creates a new instance of <seealso cref="Function"/>.</summary>
        /// <param name="name">The name of the function.</param>
        /// <param name="formula">The function formula.</param>
        /// <param name="domain">The function's domain.</param>
        /// <param name="codomain">The function's codomain.</param>
        public Function(string name, Expression formula, SetExpression domain, SetExpression codomain)
        {
            Name = name;
            Formula = formula;
            Domain = domain;
            Codomain = codomain;
            KnownValues = new Dictionary<NumberExpression, NumberExpression>();
        }
        /// <summary>Creates a new instance of <seealso cref="Function"/>.</summary>
        /// <param name="name">The name of the function.</param>
        /// <param name="formula">The function formula.</param>
        /// <param name="domain">The function's domain.</param>
        /// <param name="codomain">The function's codomain.</param>
        /// <param name="knownValues">The known values of the function.</param>
        public Function(string name, Expression formula, SetExpression domain, SetExpression codomain, Dictionary<NumberExpression, NumberExpression> knownValues)
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
            var knownValues = new Dictionary<NumberExpression, NumberExpression>();
            foreach (var kvp in left.KnownValues)
                if (right.KnownValues.ContainsKey(kvp.Key))
                {
                    var leftValue = kvp.Value;
                    var rightValue = right.KnownValues[kvp.Key];
                    knownValues.Add(kvp.Key, new NumberExpression(operation.Invoke(leftValue, rightValue), new Intersection(leftValue.ExpressionDomain, rightValue.ExpressionDomain)));
                }
            var formula = operation.Invoke(left.Formula, right.Formula) ?? null;
            return new Function($"{left.Name} {nameSeparator} {right.Name}", formula, domain, codomain, knownValues);
        }

        /// <summary>Differentiates the current expression.</summary>
        public override Expression Differentiate()
        {
            if (Formula != null)
                return base.Differentiate();

            return new Function($"{Name}'", Formula.Differentiate(), Domain, Codomain);
        }

        /// <summary>Integrates the current expression.</summary>
        public override Expression Integrate()
        {
            if (Formula != null)
                return base.Integrate();

            return new Function($"{Name}'", Formula.Integrate(), Domain, Codomain);
        }
    }
}