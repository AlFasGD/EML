using EML.Expressions.Constants;
using EML.Expressions.Operations.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions
{
    /// <summary>Represents a variable.</summary>
    public class Variable : Expression, IVariable
    {
        /// <summary>The name of the variable.</summary>
        public string Name { get; set; }

        /// <summary>Initializes a new instance of the <seealso cref="Variable"/> class.</summary>
        /// <param name="name">The name of the variable.</param>
        public Variable(string name)
        {
            Name = name;
        }

        public override Expression Differentiate(Expression expression)
        {
            if (expression == this)
                return new RealConstant(1);
            return this;
        }

        public override Expression Integrate(Expression expression)
        {
            if (expression == this)
                return new Exponentation(this, new RealConstant(2)) / new RealConstant(2);
            return this;
        }
    }
}
