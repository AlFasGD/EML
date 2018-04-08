using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    /// <summary>Provides values for the different special number sets.</summary>
    public enum SpecialNumberSet
    {
        Natural = 0x1,
        Integer = 0x2,
        Rational = 0x4,
        Real = 0x8,
        RealExtended = 0x10,
        Algebraic = 0x20,
        Complex = 0x40,
        Quaternions = 0x80,
        Octonions = 0x100 // This is actually kinda bullshit
    }
}