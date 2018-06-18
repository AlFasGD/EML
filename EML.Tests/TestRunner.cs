using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.Tests.TestClasses;

namespace EML.Tests
{
    public class TestRunner
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Executing tests...");
            new LargeIntegerTest();
            Console.ReadKey(false);
        }
    }
}
