using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Extensions.FloatingPointHelpers
{
    /// <summary>Provides tools for analyzing a <see cref="double"/>.</summary>
    public class DoubleAnalyzer
    {
        /// <summary>The bits dedicated to the exponent.</summary>
        public int ExponentBits => 11;
        /// <summary>The bits dedicated to the mantissa.</summary>
        public int MantissaBits => 52;

        private long byteSequence;
        private byte[] bytes;

        private double v;
        /// <summary>The value whose bits are analyzed.</summary>
        public double Value
        {
            get => v;
            set
            {
                v = value;
                bytes = BitConverter.GetBytes(value);
                byteSequence = BitConverter.ToInt64(bytes, 0);
            }
        }

        private bool? sign;
        /// <summary>The sign of the <see cref="double"/>.</summary>
        public bool Sign => sign ?? (sign = (bytes[0] >> 7) << 7 == 1).Value;

        private short? exponent;
        /// <summary>The exponent of the <see cref="double"/>.</summary>
        public short Exponent => exponent ?? (exponent = (short)((byteSequence << 1) >> (MantissaBits + 1))).Value;

        private long? mantissa;
        /// <summary>The mantissa of the <see cref="double"/>.</summary>
        public long Mantissa => mantissa ?? (mantissa = (byteSequence << (ExponentBits + 1)) >> (ExponentBits + 1)).Value;

        /// <summary>Creates a new instance of the <see cref="DoubleAnalyzer"/> class from a given <see cref="double"/>.</summary>
        /// <param name="value">The <see cref="double"/> to analyze.</param>
        public DoubleAnalyzer(double value)
        {
            Value = value;
        }
    }
}
