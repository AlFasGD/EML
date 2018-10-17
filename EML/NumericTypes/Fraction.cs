using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.Tools;
using EML.Exceptions;
using EML.Tools.Enumerations;
using EML.Extensions;

namespace EML.NumericTypes
{
    /// <summary>Represents a fraction.</summary>
    public struct Fraction
    {
        #region Private Members
        private bool nominatorSign = true;
        private bool denominatorSign = true;
        private LargeInteger nominator;
        private LargeInteger denominator = 1;
        #endregion
        
        #region Properties
        /// <summary>The sign of the fraction.</summary>
        public bool Sign
        {
            get => nominatorSign == denominatorSign;
            set => nominatorSign = value && (denominatorSign = true);
        }
        /// <summary>The nominator of the fraction.</summary>
        public LargeInteger Nominator
        {
            get => nominator;
            set
            {
                nominatorSign = value.BoolSign;
                value.BoolSign = true;
                nominator = value;
            }
        }
        /// <summary>The denominator of the fraction.</summary>
        public LargeInteger Denominator
        {
            get => denominator;
            set
            {
                if (value == 0)
                    throw new DivideByZeroException("The denominator cannot be zero.");
                denominatorSign = value.BoolSign;
                value.BoolSign = true;
                denominator = value;
            }
        }
        #endregion
        
        #region Constructors
        /// <summary>Creates a new instance of the <seealso cref="Fraction"/> struct.</summary>
        /// <param name="nominator">The nominator of the <seealso cref="Fraction"/>.</param>
        /// <param name="denominator">The denominator of the <seealso cref="Fraction"/>.</param>
        public Fraction(LargeInteger nom, LargeInteger denom)
        {
            if (denominator == 0)
                throw new DivideByZeroException("The denominator cannot be zero.");
            nominatorSign = nom.BoolSign;
            denominatorSign = denom.BoolSign;
            nominator = nom;
            denominator = denom;
            nominator.BoolSign = denominator.BoolSign = true;
        }
        /// <summary>Creates a new instance of the <seealso cref="Fraction"/> struct from an integral value.</summary>
        /// <param name="value">The value of the <seealso cref="Fraction"/>.</param>
        public Fraction(LargeInteger value)
        {
            nominatorSign = value.BoolSign;
            nominator = value;
            nominator.BoolSign = true;
        }
        #endregion
        
        #region Implicit Conversions
        public static implicit operator Fraction(LargeInteger a) => new Fraction(a);
        #endregion
        
        #region Operators
        public static Fraction operator +(Fraction left, Fraction right)
        {
            HomonymizeFractions(left, right, out var l, out var r);
            return new Fraction(l.Nominator + r.Nominator, l.Denominator);
        }
        public static Fraction operator -(Fraction left, Fraction right)
        {
            HomonymizeFractions(left, right, out var l, out var r);
            return new Fraction(l.Nominator - r.Nominator, l.Denominator);
        }
        public static Fraction operator *(Fraction left, Fraction right)
        {
            var result = new Fraction(left.Nominator * right.Nominator, left.Denominator * right.Denominator);
            result.Simplify();
            return result;
        }
        public static Fraction operator /(Fraction left, Fraction right)
        {
            var result = new Fraction(left.Nominator * right.Denominator, left.Denominator * right.Nominator);
            result.Simplify();
            return result;
        }
        #endregion
        
        #region Static Methods
        /// <summary>Conevrts the given fractions to their homonymous counterparts. For example, given 1/3 and 2/5, the result is 5/15 and 6/15.</summary>
        public static void HomonymizeFractions(Fraction left, Fraction right, out Fraction leftResult, out Fraction rightResult)
        {
            var lcm = LargeInteger.LeastCommonMultiple(left.Denominator, right.Denominator);
            leftResult = new Fraction(left.Nominator * lcm / left.Denominator, lcm);
            rightResult = new Fraction(right.Nominator * lcm / right.Denominator, lcm);
        }
        #endregion
        
        #region Operations
        /// <summary>Simplifies the fraction to the point where its nominator and denominator are coprime. For example, 4/8 will become 1/2.</summary>
        public void Simplify()
        {
            var gcd = LargeInteger.GreatestCommonDivisor(Nominator, Denominator);
            Nominator /= gcd;
            Denominator /= gcd;
        }
        #endregion
    }
}