using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.NumericTypes;

namespace EML.Tests.TestClasses
{
    [TestClass]
    public class LargeIntegerTest
    {
        public LargeIntegerTest()
        {
            long A = 12462;
            long B = 216745;
            LargeInteger a = A;
            LargeInteger b = B;

            Assert.IsTrue(a << 11 == A << 11);
            Console.WriteLine("Left shifting was successful.");

            Assert.IsTrue(b >> 4 == B >> 4);
            Console.WriteLine("Right shifting was successful.");

            Assert.IsTrue((a & b) == (A & B));
            Console.WriteLine("Bitwise AND was successful.");

            Assert.IsTrue((a | b) == (A | B));
            Console.WriteLine("Bitwise OR was successful.");

            Assert.IsTrue((a ^ b) == (A ^ B));
            Console.WriteLine("Bitwise XOR was successful.");

            Assert.IsTrue(a + b == A + B);
            Console.WriteLine("Addition was successful.");

            Assert.IsTrue(a - b == A - B);
            Console.WriteLine("Subtraction was successful.");

            Assert.IsTrue(a * b == A * B);
            Console.WriteLine("Multiplication was successful.");

            Assert.IsTrue(b / a == B / A);
            Console.WriteLine("Division was successful.");

            Assert.IsTrue(b % a == B % A);
            Console.WriteLine("Modulus was successful.");
        }
    }
}
