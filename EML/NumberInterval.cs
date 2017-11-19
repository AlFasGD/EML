using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EML
{
    /// <summary>Represents a number interval.</summary>
    public class RealNumberInterval : NumberSet
    {
        public SpecialNumberSet IntervalDomain { get; set; }
        public bool IsCompleteIntervalDomain { get; set; }
        public NumberExpression Left { get; set; }
        public NumberExpression Right { get; set; }
        public bool ClosedLeft { get; set; }
        public bool ClosedRight { get; set; }

        public RealNumberInterval(NumberExpression left, NumberExpression right, bool closedLeft, bool closedRight)
        {
            IntervalDomain = SpecialNumberSet.Real;
            IsCompleteIntervalDomain = false;
            Left = left;
            Right = right;
            ClosedLeft = closedLeft;
            ClosedRight = closedRight;
        }
        public RealNumberInterval(NumberExpression left, NumberExpression right, bool closedLeft, bool closedRight, SpecialNumberSet s)
        {
            IntervalDomain = s;
            IsCompleteIntervalDomain = false;
            Left = left;
            ClosedLeft = closedLeft;
            ClosedRight = closedRight;
            Right = right;
        }
        public RealNumberInterval(SpecialNumberSet s)
        {
            IntervalDomain = s;
            IsCompleteIntervalDomain = true;
            Left = null;
            Right = null;
            ClosedLeft = false;
            ClosedRight = false;
        }
        
        public static bool IsSubset(RealNumberInterval target, RealNumberInterval container)
        {
            if (target.IntervalDomain == container.IntervalDomain)
            {
                if (container.IsCompleteIntervalDomain) return true;
                if (container.Left <= target.Left && container.Right >= target.Right) return true;
                return false;
            }
            else return false;
        }

        public static bool operator ==(RealNumberInterval left, RealNumberInterval right)
        {
            if (left.IntervalDomain == right.IntervalDomain)
            {
                if (left.IsCompleteIntervalDomain == right.IsCompleteIntervalDomain)
                    return true;
                else
                    return left.Left == right.Left && left.Right == right.Right && left.ClosedLeft == right.ClosedLeft && left.ClosedRight == right.ClosedRight;
            }
            return false;
        }
        public static bool operator !=(RealNumberInterval left, RealNumberInterval right)
        {
            if (left.IntervalDomain != right.IntervalDomain)
            {
                if (left.IsCompleteIntervalDomain != right.IsCompleteIntervalDomain)
                    return true;
                else
                    return left.Left != right.Left && left.Right != right.Right && left.ClosedLeft != right.ClosedLeft && left.ClosedRight != right.ClosedRight;
            }
            return false;
        }
    }
}