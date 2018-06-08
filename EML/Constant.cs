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
    // Probably to be removed since it is not frequently encountered
    /// <summary>Represents a constant in mathematics.</summary>
    public class Constant
    {
        public string Name { get; set; }
        public LargeDecimal Value { get; set; }

        public Constant(string name, LargeDecimal value)
        {
            Name = name;
            Value = value;
        }

        public static bool operator <(Constant left, Constant right) => left.Value < right.Value;
        public static bool operator >(Constant left, Constant right) => left.Value > right.Value;
        public static bool operator <=(Constant left, Constant right) => left.Value <= right.Value;
        public static bool operator >=(Constant left, Constant right) => left.Value >= right.Value;
        public static bool operator ==(Constant left, Constant right) => left.Value == right.Value;
        public static bool operator !=(Constant left, Constant right) => left.Value != right.Value;
    }
}
