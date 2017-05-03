using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    /// <summary>Represents an arbitrarily large integer.</summary>
    public struct LargeInteger
    {
        List<byte> Bytes { get; }

        #region Constructors
        public LargeInteger(int i)
        {
            Bytes = new List<byte>();
            Bytes.AddRange(BitConverter.GetBytes(i));
        }
        #endregion

        #region Implicit Conversions
        #endregion

        #region Operators
        #endregion

        #region Operations
        #endregion
    }
}
