using System;
using System.Runtime.InteropServices;

namespace EML.Exceptions
{
    /// <summary>The exception that is thrown when trying to calculate the factorization of two numbers when the starting number is greater than the ending one.</summary>
    [ComVisible(true)]
    [Serializable]
    public class InvalidFactorizationVariableOrderException : ArithmeticException
    {
        /// <summary>Initializes a new instance of the <see cref="InvalidFactorizationVariableOrderException"/> class.</summary>
        public InvalidFactorizationVariableOrderException() : base("Cannot calculate the factorization of two numbers when the starting number is greater than the ending one.") { }
        /// <summary>Initializes a new instance of the <see cref="InvalidFactorizationVariableOrderException"/> class with a specified error message.</summary>
        /// <param name="message">A string that describes the error.</param>
        public InvalidFactorizationVariableOrderException(string message) : base(message, new InvalidFactorizationVariableOrderException()) { }
    }
}