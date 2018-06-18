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
            LargeInteger a =  12462;
            LargeInteger b = 216745;

            LargeInteger sum = a + b;
            LargeInteger targetSum = 229207;

            Assert.AreEqual(sum, targetSum);
            Console.WriteLine("Sum was successful.");

            LargeInteger difference = a - b;
            LargeInteger targetDifference = 195717;

            Assert.AreEqual(difference, targetDifference);
            Console.WriteLine("Difference was successful.");

            LargeInteger product = a * b;
            LargeInteger targetProduct = 2701076190;

            Assert.AreEqual(product, targetProduct);
            Console.WriteLine("Product was successful.");

            LargeInteger division = b / a;
            LargeInteger targetDivision = 17;

            Assert.AreEqual(division, targetDivision);
            Console.WriteLine("Division was successful.");
        }
    }
}
