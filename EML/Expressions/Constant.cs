using EML.Expressions.Constants;

namespace EML.Expressions
{
    /// <summary>Represents a constant.</summary>
    public abstract class Constant : Expression, INumericExpression
    {
        /// <summary>The name of the constant.</summary>
        public string Name { get; set; }

        /// <summary>Initializes a new instance of the <seealso cref="Constant"/> class.</summary>
        /// <param name="name">The name of the constant.</param>
        public Constant(string name)
        {
            Name = name;
        }

        public override Expression Differentiate(Expression expression) => new RealConstant(0);

        public override Expression Integrate(Expression expression) => this * expression;
    }
}