using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.NumericTypes;
using EML.Sets;
using EML.Tools;
using EML.Exceptions;
using EML.Expressions;

namespace EML
{
    /// <summary>Represents a function.</summary>
    public class Function
    {
        /// <summary>The name of the function.</summary>
        public string Name;
        /// <summary>The function formula.</summary>
        public Expression Formula;
        /// <summary>The function's domain.</summary>
        public NumberSet Domain;
        /// <summary>The function's codomain.</summary>
        public NumberSet Codomain;
        /// <summary>The known values of the function.</summary>
        public List<(NumberExpression, NumberExpression)> KnownValues;

        /// <summary>Creates a new instance of <seealso cref="Function"/>.</summary>
        /// <param name="name">The name of the function.</param>
        /// <param name="domain">The function's domain.</param>
        /// <param name="codomain">The function's codomain.</param>
        /// <param name="knownValues">The known values of the function.</param>
        public Function(string name, NumberSet domain, NumberSet codomain, List<(NumberExpression, NumberExpression)> knownValues)
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
        public Function(string name, Expression formula, NumberSet domain, NumberSet codomain)
        {
            Name = name;
            Formula = formula;
            Domain = domain;
            Codomain = codomain;
            KnownValues = new List<(NumberExpression, NumberExpression)>();
        }
        /// <summary>Creates a new instance of <seealso cref="Function"/>.</summary>
        /// <param name="name">The name of the function.</param>
        /// <param name="formula">The function formula.</param>
        /// <param name="domain">The function's domain.</param>
        /// <param name="codomain">The function's codomain.</param>
        /// <param name="knownValues">The known values of the function.</param>
        public Function(string name, Expression formula, NumberSet domain, NumberSet codomain, List<(NumberExpression, NumberExpression)> knownValues)
        {
            Name = name;
            Formula = formula;
            Domain = domain;
            Codomain = codomain;
            KnownValues = knownValues;
        }
    }
}