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
        public ElevateZeroToThePowerOfZeroException() : base() { }
        /// <summary>Initializes a new instance of the <see cref="ElevateZeroToThePowerOfZeroException"/> class with a specified error message.</summary>
        /// <param name="message">A string that describes the error.</param>
        public ElevateZeroToThePowerOfZeroException(String message) : base(message) { }
        /// <summary>Initializes a new instance of the <see cref="ElevateZeroToThePowerOfZeroException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the innerException parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
        public ElevateZeroToThePowerOfZeroException(String message, Exception innerException) : base(message, innerException) { }
    }
}
