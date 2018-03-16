using System;
using System.Runtime.InteropServices;

namespace EML
{
    /// <summary>The exception that is thrown when trying to elevate zero to the power of zero.</summary>
    [ComVisible(true)]
    [Serializable]
    public class ElevateZeroToThePowerOfZeroException : ArithmeticException
    {
        /// <summary>Initializes a new instance of the <see cref="ElevateZeroToThePowerOfZeroException"/> class.</summary>
        public ElevateZeroToThePowerOfZeroException() : base("Cannot elevate zero to the power of zero.") { }
        /// <summary>Initializes a new instance of the <see cref="ElevateZeroToThePowerOfZeroException"/> class with a specified error message.</summary>
        /// <param name="message">A string that describes the error.</param>
        public ElevateZeroToThePowerOfZeroException(string message) : base(message, new ElevateZeroToThePowerOfZeroException()) { }
    }
}