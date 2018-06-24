using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Tools.Enumerations
{
    /// <summary>Represents the sign of a number.</summary>
    public enum Sign
    {
        /// <summary>The negative sign.</summary>
        Negative = -1,
        /// <summary>The neutral sign (also denoetd as zero).</summary>
        Neutral = 0,
        /// <summary>The positive sign.</summary>
        Positive = 1
    }

    /// <summary>Provides helpful functions related to the <seealso cref="Sign"/> enumeration.</summary>
    public static class SignFunctions
    {
        /// <summary>Inverts a <seealso cref="Sign"/>.</summary>
        /// <param name="sign">The <seealso cref="Sign"/> to invert.</param>
        public static Sign Invert(Sign sign) => (Sign)(-(int)sign);
        /// <summary>Multiplies two <seealso cref="Sign"/>s.</summary>
        /// <param name="left">The left <seealso cref="Sign"/> of the multiplication.</param>
        /// <param name="right">The right <seealso cref="Sign"/> of the multiplication.</param>
        public static Sign Multiply(Sign left, Sign right) => (Sign)((int)left * (int)right);
    }
}
