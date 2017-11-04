using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    /// <summary>Represents a number interval.</summary>
    public struct NumberInterval
    {
        SpecialNumberSet IntervalDomain { get; set; }
        bool IsCompleteIntervalDomain { get; set; }
        NumberExpression Left { get; set; }
        NumberExpression Right { get; set; }

        public NumberInterval(NumberExpression left, NumberExpression right)
        {
            IntervalDomain = SpecialNumberSet.Real;
            IsCompleteIntervalDomain = false;
            Left = left;
            Right = right;
        }
        public NumberInterval(NumberExpression left, NumberExpression right, SpecialNumberSet s)
        {
            IntervalDomain = s;
            IsCompleteIntervalDomain = false;
            Left = left;
            Right = right;
        }
        public NumberInterval(SpecialNumberSet s)
        {
            IntervalDomain = s;
            IsCompleteIntervalDomain = true;
            Left = null;
            Right = null;
        }
    }
}