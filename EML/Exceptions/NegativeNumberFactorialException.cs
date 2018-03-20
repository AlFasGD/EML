using System;
using System.Runtime.InteropServices;

namespace EML
{
    /// <summary>The exception that is thrown when trying to calculate the factorial of a negative number.</summary>
    [ComVisible(true)]
    [Serializable]
    public class NegativeNumberFactorialException : ArithmeticException
    {
        /// <summary>Initializes a new instance of the <see cref="NegativeNumberFactorialException"/> class.</summary>
        public NegativeNumberFactorialException() : base("Cannot calculate the factorial of a negative number.") { }
        /// <summary>Initializes a new instance of the <see cref="NegativeNumberFactorialException"/> class with a specified error message.</summary>
        /// <param name="message">A string that describes the error.</param>
        public NegativeNumberFactorialException(string message) : base(message, new NegativeNumberFactorialException()) { }
    }
}