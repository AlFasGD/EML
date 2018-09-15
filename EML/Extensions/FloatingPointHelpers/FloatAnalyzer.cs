using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML.Extensions.FloatingPointHelpers
{
    /// <summary>Provides tools for analyzing a <see cref="float"/>.</summary>
    public class FloatAnalyzer
    {
        /// <summary>The bits dedicated to the exponent.</summary>
        public const int ExponentBits = 8;
        /// <summary>The bits dedicated to the mantissa.</summary>
        public const int MantissaBits = 23;
        /// <summary>The bias of the exponent.</summary>
        public const int ExponentBias = 127;

        private int byteSequence;
        private byte[] bytes;

        private float v;
        /// <summary>The value whose bits are analyzed.</summary>
        public float Value
        {
            get => v;
            set
            {
                v = value;
                bytes = BitConverter.GetBytes(value);
                byteSequence = BitConverter.ToInt32(bytes, 0);
                sign = null;
                exponent = null;
                mantissa = null;
            }
        }

        private bool? sign;
        /// <summary>The sign of the <see cref="float"/>.</summary>
        public bool Sign => sign ?? (sign = (bytes[0] >> 7) << 7 == 1).Value;

        private short? exponent;
        /// <summary>The exponent of the <see cref="float"/>.</summary>
        public short Exponent => exponent ?? (short)((exponent = (short)((byteSequence << 1) >> (MantissaBits + 1))).Value - ExponentBias);

        private int? mantissa;
        /// <summary>The mantissa of the <see cref="float"/>.</summary>
        public int Mantissa => mantissa ?? (mantissa = (byteSequence << (ExponentBits + 1)) >> (ExponentBits + 1)).Value;

        /// <summary>Creates a new instance of the <see cref="FloatAnalyzer"/> class from a given <see cref="float"/>.</summary>
        /// <param name="value">The <see cref="float"/> to analyze.</param>
        public FloatAnalyzer(float value)
        {
            Value = value;
        }
    }
}
