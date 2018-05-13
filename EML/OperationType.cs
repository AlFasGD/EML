using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.NumericTypes;
using EML.Sets;
using EML.Tools;
using EML.Exceptions;

namespace EML
{
    /// <summary>Provides values for the different operation types.</summary>
    public enum OperationType
    {
        Addition = 0,
        Subtraction = 1,
        Multiplication = 2,
        Division = 3,
        Power = 4,
        Root = 5,
        Arrow = 6,

        Factorial = 10,

        Sum = 100,
        Product = 101,

        Derivative = 1000,
        Integral = 1001,

        OpenParenthesis = 100000,
        ClosedParenthesis = 100001,
    }
}
