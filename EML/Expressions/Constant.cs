using EML.Expressions.Constants;

namespace EML.Expressions
{
	/// <summary>Represents a constant.</summary>
    public abstract class Constant : Expression
    {
        public override Expression Differentiate(Expression expression) => new RealConstant(0);
    }
}