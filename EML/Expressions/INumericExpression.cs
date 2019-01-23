using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Expressions
{
    /// <summary>Represents a numeric expression.</summary>
    public interface INumericExpression
    {
        /// <summary>Compares the current expression with another expression and returns <see langword="true"/> if this experssion is greater than the other, otherwise <see langword="false"/>.</summary>
        /// <param name="expression">The expression to compare the current one with.</param>
        bool GreaterThan(INumericExpression expression);
        /// <summary>Compares the current expression with another expression and returns <see langword="true"/> if this experssion is greater than or equal to the other, otherwise <see langword="false"/>.</summary>
        /// <param name="expression">The expression to compare the current one with.</param>
        bool GreaterThanOrEqualTo(INumericExpression expression);
        /// <summary>Compares the current expression with another expression and returns <see langword="true"/> if this experssion is equal to the other, otherwise <see langword="false"/>.</summary>
        /// <param name="expression">The expression to compare the current one with.</param>
        bool EqualTo(INumericExpression expression);
        /// <summary>Compares the current expression with another expression and returns <see langword="true"/> if this experssion is less than or equal to the other, otherwise <see langword="false"/>.</summary>
        /// <param name="expression">The expression to compare the current one with.</param>
        bool LessThanOrEqualTo(INumericExpression expression);
        /// <summary>Compares the current expression with another expression and returns <see langword="true"/> if this experssion is less than the other, otherwise <see langword="false"/>.</summary>
        /// <param name="expression">The expression to compare the current one with.</param>
        bool LessThan(INumericExpression expression);
        /// <summary>Compares the current expression with another expression and returns <see langword="true"/> if this experssion is different than the other, otherwise <see langword="false"/>.</summary>
        /// <param name="expression">The expression to compare the current one with.</param>
        bool DifferentThan(INumericExpression expression);
    }
}
