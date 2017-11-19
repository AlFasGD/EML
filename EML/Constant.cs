using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    public class Constant
    {
        public string Name { get; set; }
        public LargeDecimal Value { get; set; }

        public static bool operator <(Constant left, Constant right) => left.Value < right.Value;
        public static bool operator >(Constant left, Constant right) => left.Value > right.Value;
        public static bool operator <=(Constant left, Constant right) => left.Value <= right.Value;
        public static bool operator >=(Constant left, Constant right) => left.Value >= right.Value;
        public static bool operator ==(Constant left, Constant right) => left.Value == right.Value;
        public static bool operator !=(Constant left, Constant right) => left.Value != right.Value;
    }
}
